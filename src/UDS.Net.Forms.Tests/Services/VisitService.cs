using System;
using UDS.Net.Dto;
using UDS.Net.Services;
using UDS.Net.Services.Models;

namespace UDS.Net.Forms.Tests.Services
{
    public class VisitService : IVisitService
    {
        public List<Visit> Visits { get; set; } = new List<Visit>();

        public VisitService()
        {
            Visits = GetSeedingVisits();
        }

        public Task<Visit> Add(string username, Visit entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Count(string username)
        {
            throw new NotImplementedException();
        }

        public Task<Visit> GetById(string username, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Visit>> List(string username, int pageSize = 10, int pageIndex = 1)
        {
            return Visits;
        }

        public Task<Visit> Patch(string username, Visit entity)
        {
            throw new NotImplementedException();
        }

        public Task Remove(string username, Visit entity)
        {
            throw new NotImplementedException();
        }

        public Task<Visit> Update(string username, Visit entity)
        {
            throw new NotImplementedException();
        }

        public static List<Visit> GetSeedingVisits()
        {
            return new List<Visit>()
            {
                new Visit() { Id = 1, Number = 1 },
                new Visit() { Id = 2, Number = 2 },
                new Visit() { Id = 3, Number = 3 },
                new Visit() { Id = 4, Number = 4 },
                new Visit() { Id = 5, Number = 5 }
            };
        }
    }
}

