using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public class VisitClient : AuthenticatedClient<VisitDto>, IVisitClient
    {
        const string BASEPATH = "Visits";

        public VisitClient(HttpClient httpClient) : base(httpClient, BASEPATH)
        {
        }
    }
}

