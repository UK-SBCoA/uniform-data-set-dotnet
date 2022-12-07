using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface IVisitClient
    {
        Task<IEnumerable<VisitDto>> Get();
        Task<int> Count();
        Task<VisitDto> Get(int id);
        Task Post(VisitDto dto);
        Task Put(int id, VisitDto dto);
        Task Delete(int id);
    }
}

