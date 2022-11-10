using System;
using UDS.Net.API.Client;
using UDS.Net.Dto;
using UDS.Net.Services;
using UDS.Net.Services.Extensions;
using UDS.Net.Services.DomainModels;

namespace UDS.Net.Web.MVC.Services
{
    public class ParticipationService : IParticipationService
    {
        private readonly IApiClient _apiClient;

        public ParticipationService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<Participation> Add(string username, Participation entity)
        {
            return new Participation
            {
                Id = 1,
                LegacyId = "1",
                Visits = new List<Visit>
                {
                    new Visit("UDS3", "IVP") { Id = 1, Number = 1 }
                }
            };
        }

        public async Task<int> Count(string username)
        {
            return 6;
        }

        public async Task<Participation> GetById(string username, int id)
        {
            return new Participation
            {
                Id = 1,
                LegacyId = "1",
                Visits = new List<Visit>
                {
                    new Visit("UDS3", "IVP") { Id = 1, Number = 1 }
                }
            };
        }

        public async Task<IEnumerable<Participation>> List(string username, int pageSize = 10, int pageIndex = 1)
        {
            return new List<Participation>()
            {
                new Participation{ Id = 1, LegacyId = "1", Visits = new List<Visit> { new Visit("UDS3", "IVP") { Id = 1, Number = 1} }},
                new Participation{ Id = 2, LegacyId = "2", Visits = new List<Visit> { new Visit("UDS3", "IVP") { Id = 2, Number = 1 } }},
                new Participation{ Id = 3, LegacyId = "3", Visits = new List<Visit> { new Visit("UDS3", "IVP") { Id = 3, Number = 1 } }},
                new Participation{ Id = 4, LegacyId = "4", Visits = new List<Visit> { new Visit("UDS3", "IVP") { Id = 4, Number = 1 } }},
                new Participation{ Id = 5, LegacyId = "5", Visits = new List<Visit> { new Visit("UDS3", "IVP") { Id = 5, Number = 1 } }},
                new Participation{ Id = 6, LegacyId = "6", Visits = new List<Visit> { new Visit("UDS3", "IVP") { Id = 6, Number = 1 } }},
            };
        }

        public async Task<Participation> Patch(string username, Participation entity)
        {
            return new Participation
            {
                Id = 1,
                LegacyId = "1",
                Visits = new List<Visit>
                {
                    new Visit("UDS3", "IVP") { Id = 1, Number = 1 }
                }
            };
        }

        public async Task Remove(string username, Participation entity)
        {
        }

        public async Task<Participation> Update(string username, Participation entity)
        {
            return new Participation
            {
                Id = 1,
                LegacyId = "1",
                Visits = new List<Visit>
                {
                    new Visit("UDS3", "IVP") { Id = 1, Number = 1 }
                }
            };
        }
    }
}

