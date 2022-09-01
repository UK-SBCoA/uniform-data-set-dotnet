using System;
using System.Net;
using System.Text.Json;
using UDS.Net.Dto;
using UDS.Net.Services;
using UDS.Net.Services.Extensions;
using UDS.Net.Services.Models;

namespace UDS.Net.Web.MVC.Services
{
    public class VisitService : IVisitService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public VisitService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _baseUrl = configuration["DownstreamApis:UDSNetApi:BaseUrl"];
        }

        public Task<Visit> Add(string username, Visit entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Count(string username)
        {
            throw new NotImplementedException();
        }

        public Task<Visit> GetById(string username, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Visit>> List(string username, int pageSize = 10, int pageIndex = 1)
        {
            // https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#implement-your-typed-client-classes-that-use-the-injected-and-configured-httpclient
            var response = await _httpClient.GetAsync($"{_baseUrl}/Visits");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (response.Content != null)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    if (content != null && !content.Equals("[]"))
                    {
                        List<VisitDto> dto = JsonSerializer.Deserialize<List<VisitDto>>(content)!;

                        return dto.Select(d => d.ToDomain()).ToList();
                    }
                }
            }

            return new List<Visit>();
        }

        public Task<Visit> Patch(string username, Visit entity)
        {
            throw new NotImplementedException();
        }

        public Task Remove(string username, Visit entity)
        {
            throw new NotImplementedException();
        }

        public Task<Visit> Update(string username, Visit entity)
        {
            throw new NotImplementedException();
        }
    }
}

