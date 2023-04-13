
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface IBaseClient<T>
    {
        Task<IEnumerable<T>> Get();
        Task<int> Count();
        Task<T> Get(int id);
        Task Post(T dto);
        Task Put(int id, T dto);
        Task Delete(int id);
    }
}

