using System;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface IVisitClient : IBaseClient<VisitDto>
    {
        Task<VisitDto> GetWithForm(int id, string formId);
    }
}

