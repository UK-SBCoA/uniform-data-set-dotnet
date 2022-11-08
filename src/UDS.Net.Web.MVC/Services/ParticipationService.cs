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
            throw new NotImplementedException();
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

