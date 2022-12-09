using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public class ParticipationClient : AuthenticatedClient<ParticipationDto>, IParticipationClient
    {
        const string BASEPATH = "Participations";

        public ParticipationClient(HttpClient httpClient) : base(httpClient, BASEPATH)
        {
        }
    }
}

