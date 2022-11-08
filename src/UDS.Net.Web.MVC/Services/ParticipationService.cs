using System;
using UDS.Net.API.Client;
using UDS.Net.Dto;
using UDS.Net.Services;
using UDS.Net.Services.Extensions;
using UDS.Net.Services.Models;

namespace UDS.Net.Web.MVC.Services
{
    public class ParticipationService : IParticipationService
    {
        private readonly IApiClient _apiClient;

        public ParticipationService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Task<Participation> Add(string username, Participation entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Count(string username)
        {
            throw new NotImplementedException();
        }

        public Task<Participation> GetById(string username, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Participation>> List(string username, int pageSize = 10, int pageIndex = 1)
        {
            return new List<Participation>()
            {
                new Participation{ Id = 1, LegacyId = "1", Visits = new List<Visit> { new Visit { Id = 1, Number = 1, Version = "UDS3" } }},
                new Participation{ Id = 2, LegacyId = "2", Visits = new List<Visit> { new Visit { Id = 2, Number = 1, Version = "UDS3" } }},
                new Participation{ Id = 3, LegacyId = "3", Visits = new List<Visit> { new Visit { Id = 3, Number = 1, Version = "UDS3" } }},
                new Participation{ Id = 4, LegacyId = "4", Visits = new List<Visit> { new Visit { Id = 4, Number = 1, Version = "UDS3" } }},
                new Participation{ Id = 5, LegacyId = "5", Visits = new List<Visit> { new Visit { Id = 5, Number = 1, Version = "UDS3" } }},
                new Participation{ Id = 6, LegacyId = "6", Visits = new List<Visit> { new Visit { Id = 6, Number = 1, Version = "UDS3" } }},
            };
        }

        public Task<Participation> Patch(string username, Participation entity)
        {
            throw new NotImplementedException();
        }

        public Task Remove(string username, Participation entity)
        {
            throw new NotImplementedException();
        }

        public Task<Participation> Update(string username, Participation entity)
        {
            throw new NotImplementedException();
        }
    }
}

