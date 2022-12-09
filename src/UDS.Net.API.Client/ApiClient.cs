using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace UDS.Net.API.Client
{
    public static class UDSApiExtensions
    {
        public static void AddUDSApiClient(this IServiceCollection services, string baseAddress)
        {
            if (!baseAddress.EndsWith("/"))
                baseAddress += "/"; // you MUST place a slash at the end of the baseaddress

            // Register all clients
            services.AddHttpClient<IVisitClient, VisitClient>(options =>
            {
                options.BaseAddress = new Uri(baseAddress); 
            }); // can be configured for retry and transient-fault-handling

            // API client registered last
            services.AddSingleton<IApiClient, ApiClient>();
        }
    }

    /// <summary>
    /// Typed Client
    /// https://learn.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests
    /// </summary>
    public class ApiClient : IApiClient
    {
        public IVisitClient VisitClient { get; }

        public ApiClient(IVisitClient visitClient)
        {
            VisitClient = visitClient;
        }

        
    }
}

