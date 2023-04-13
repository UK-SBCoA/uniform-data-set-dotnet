using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace UDS.Net.API.Client
{
    // https://learn.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#implement-your-typed-client-classes-that-use-the-injected-and-configured-httpclient
    public class AuthenticatedClient<T> : IBaseClient<T>
    {
        //private readonly IHttpContextAccessor _contextAccessor;

        protected readonly HttpClient _httpClient;

        protected readonly string _ApiScope = "UDS.ReadWrite.All";

        protected readonly string _BasePath = "";

        //private readonly ITokenAcquisition _tokenAcquisition;

        protected JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public AuthenticatedClient(HttpClient httpClient, string basePath)
        {
            // HttpClient is intended to be instantiated once and reused throughout the life of an application.
            _httpClient = httpClient;
            _BasePath = basePath;
        }

        //public AuthenticatedClient(ITokenAcquisition tokenAcquisition, HttpClient httpClient, IConfiguration configuration, IHttpContextAccessor contextAccessor)
        //{
        //    _httpClient = httpClient;
        //    _tokenAcquisition = tokenAcquisition;
        //    _contextAccessor = contextAccessor;
        //    _StudiesScope = configuration["DownstreamApis:StudiesApi:Scope"];
        //    _StudiesBaseAddress = configuration["DownstreamApis:StudiesApi:Url"];
        //}

        protected async Task PrepareAuthenticatedClient()
        {
            //var accessToken = await _tokenAcquisition.GetAccessTokenForUserAsync(new[] { _ApiScope });
            //_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        protected async Task<string> GetRequest(string url)
        {
            await PrepareAuthenticatedClient();

            var response = await _httpClient.GetAsync(url);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
            throw new HttpRequestException($"The path {url} returns the following status code: {response.StatusCode}");
        }

        protected async Task<string> PostRequest(string url, string jsonObject)
        {
            await PrepareAuthenticatedClient();

            var content = new StringContent(jsonObject, System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);

            if (response.StatusCode == System.Net.HttpStatusCode.OK || response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                var responseContent = await response.Content.ReadAsStringAsync();

                return responseContent;
            }

            throw new HttpRequestException($"Invalid status code in the HttpResponseMessage: {response.StatusCode}.");
        }

        public async Task<IEnumerable<T>> Get()
        {
            string response = await GetRequest(_BasePath);

            List<T> values = JsonSerializer.Deserialize<List<T>>(response, options); //Newtonsoft JsonConvert.DeserializeObject<List<T>>(response);

            return values;
        }

        public async Task<int> Count()
        {
            string response = await GetRequest($"{_BasePath}/Count");

            int count = JsonSerializer.Deserialize<int>(response, options);//JsonConvert.DeserializeObject<int>(response);

            return count;
        }

        public async Task<T> Get(int id)
        {
            string response = await GetRequest($"{_BasePath}/{id}");

            T value = JsonSerializer.Deserialize<T>(response, options);// JsonConvert.DeserializeObject<T>(response);

            return value;
        }

        public async Task Post(T dto)
        {
            var json = JsonSerializer.Serialize(dto);//JsonConvert.SerializeObject(dto);

            string response = await PostRequest(_BasePath, json);

            /// TODO how to handle failures?
        }

        public Task Put(int id, T dto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

