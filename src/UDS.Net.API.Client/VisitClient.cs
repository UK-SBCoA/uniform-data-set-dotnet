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
        public Task Delete(int id)
        {
            throw new NotImplementedException();
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

        public Task Post(VisitDto dto)
        {
            throw new NotImplementedException();
        }

        public Task Put(int id, VisitDto dto)
        {
            throw new NotImplementedException();
        }

    }
}

