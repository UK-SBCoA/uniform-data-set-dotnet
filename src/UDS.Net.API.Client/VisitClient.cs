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
            // NOTE The response contains the correctly serialized derived form object
            var response = await GetRequest($"{_BasePath}/{id}/Forms/{formId}");
            Console.WriteLine(response);
            // Newtonsoft:
            // VisitDto dto = JsonConvert.DeserializeObject<VisitDto>(response);

            // Defining the JsonNamingPolicy makes the deserializer correctly work


            VisitDto? dto = JsonSerializer.Deserialize<VisitDto>(response, options);

            return dto;
        }
    }
}

