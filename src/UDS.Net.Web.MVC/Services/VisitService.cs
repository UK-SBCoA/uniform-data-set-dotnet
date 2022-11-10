using System;
using System.Net;
using System.Text.Json;
using UDS.Net.API.Client;
using UDS.Net.Dto;
using UDS.Net.Services;
using UDS.Net.Services.Extensions;
using UDS.Net.Services.DomainModels;

namespace UDS.Net.Web.MVC.Services
{
    /// <summary>
    /// This service uses this API client and maps to domain model used in
    /// the component librar
    /// </summary>
    public class VisitService : IVisitService
    {
        private readonly IApiClient _apiClient;

        public VisitService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<Visit> Add(string username, Visit entity)
        {
            return new Visit("UDS3", "IVP") { Id = 1, Number = 1 };
        }

        public async Task<int> Count(string username)
        {
            return 1;
        }

        public async Task<Visit> GetById(string username, int id)
        {
            return new Visit("UDS3", "IVP") { Id = 1, Number = 1 };
        }

        public async Task<IEnumerable<Visit>> List(string username, int pageSize = 10, int pageIndex = 1)
        {
            var visitDtos = await _apiClient.VisitClient.Get();

            if (visitDtos != null)
            {
                return visitDtos.Select(d => d.ToDomain()).ToList();
            }

            return new List<Visit>();
        }

        public async Task<Visit> Patch(string username, Visit entity)
        {
            return new Visit("UDS3", "IVP") { Id = 1, Number = 1 };
        }

        public async Task Remove(string username, Visit entity)
        {
        }

        public async Task<Visit> Update(string username, Visit entity)
        {
            return new Visit("UDS3", "IVP") { Id = 1, Number = 1 };
        }
    }
}

