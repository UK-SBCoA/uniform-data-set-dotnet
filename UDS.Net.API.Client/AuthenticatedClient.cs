using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace UDS.Net.API.Client
{
    // https://learn.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#implement-your-typed-client-classes-that-use-the-injected-and-configured-httpclient
    public class AuthenticatedClient
    {
        //private readonly IHttpContextAccessor _contextAccessor;

        private readonly HttpClient _httpClient;

        private readonly string _ApiScope = string.Empty;

        private readonly string _baseUrl = string.Empty;

        //private readonly ITokenAcquisition _tokenAcquisition;


        public AuthenticatedClient()
        {
            _httpClient = new HttpClient();
            _baseUrl = "http://uds.net.api:80/api";// configuration["DownstreamApis:UDSNetApi:BaseUrl"];
        }

        //public AuthenticatedClient(ITokenAcquisition tokenAcquisition, HttpClient httpClient, IConfiguration configuration, IHttpContextAccessor contextAccessor)
        //{
        //    _httpClient = httpClient;
        //    _tokenAcquisition = tokenAcquisition;
        //    _contextAccessor = contextAccessor;
        //    _StudiesScope = configuration["DownstreamApis:StudiesApi:Scope"];
        //    _StudiesBaseAddress = configuration["DownstreamApis:StudiesApi:Url"];
        //}

        private async Task PrepareAuthenticatedClient()
        {
            //    var accessToken = await _tokenAcquisition.GetAccessTokenForUserAsync(new[] { _StudiesScope });
            //    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            //    _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GetRequest(string url)
        {
            await PrepareAuthenticatedClient();

            var response = await _httpClient.GetAsync($"{_baseUrl}/{url}");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
            throw new HttpRequestException($"The path {url} returns the following status code: {response.StatusCode}");
        }

    }
}

