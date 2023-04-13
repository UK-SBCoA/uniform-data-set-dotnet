using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public class VisitClient : AuthenticatedClient<VisitDto>, IVisitClient
    {
        const string BASEPATH = "Visits";

        public VisitClient(HttpClient httpClient) : base(httpClient, BASEPATH)
        {
        }

        public async Task<VisitDto> GetWithForm(int id, string formId)
        {
            var response = await GetRequest($"{_BasePath}/{id}/Forms/{formId}");

            VisitDto? dto = JsonSerializer.Deserialize<VisitDto>(response, options);

            return dto;
        }
    }
}

