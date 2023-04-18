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
            // TODO can be configured for retry and transient-fault-handling
            services.AddHttpClient<IVisitClient, VisitClient>(options =>
            {
                options.BaseAddress = new Uri(baseAddress);
            });

            services.AddHttpClient<IParticipationClient, ParticipationClient>(options =>
            {
                options.BaseAddress = new Uri(baseAddress);
            });

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
        public IParticipationClient ParticipationClient { get; }

        public ApiClient(IVisitClient visitClient, IParticipationClient participationClient)
        {
            VisitClient = visitClient;
            ParticipationClient = participationClient;
        }


    }
}

