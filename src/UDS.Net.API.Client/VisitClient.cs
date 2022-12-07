using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public class VisitClient : AuthenticatedClient, IVisitClient
    {
        public VisitClient(HttpClient httpClient) : base(httpClient)
        {
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Count()
        {
            string response = await GetRequest("Visits/Count");

            int visitCount = JsonConvert.DeserializeObject<int>(response);

            return visitCount;
        }

        public async Task<IEnumerable<VisitDto>> Get()
        {
            string response = await GetRequest("Visits");

            List<VisitDto> visits = JsonConvert.DeserializeObject<List<VisitDto>>(response);

            return visits;
        }

        public async Task<VisitDto> Get(int id)
        {
            string response = await GetRequest($"Visits/{id}");

            VisitDto visit = JsonConvert.DeserializeObject<VisitDto>(response);

            return visit;
        }

        public async Task Post(VisitDto dto)
        {
            var json = JsonConvert.SerializeObject(dto);

            string response = await PostRequest("Visits", json);

            /// TODO how to handle failures?
        }

        public Task Put(int id, VisitDto dto)
        {
            throw new NotImplementedException();
        }

    }
}

