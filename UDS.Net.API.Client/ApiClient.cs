using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace UDS.Net.API.Client
{
    public static class UDSApiExtensions
    {
        public static void AddApiClient(this IServiceCollection services)
        {
            services.AddSingleton<IVisitClient, VisitClient>();

            // API client registered last
            services.AddSingleton<IApiClient, ApiClient>();
        }
    }

    public class ApiClient : IApiClient
    {
        public IVisitClient VisitClient { get; }

        public ApiClient(IVisitClient visitClient)
        {
            VisitClient = visitClient;
        }

        
    }
}

