using System;
using UDS.Net.Dto;
using UDS.Net.Services.Models;

namespace UDS.Net.Services.Extensions
{
    public static class DtoToDomainMapper
    {
        public static Visit ToDomain(this VisitDto dto)
        {
            return new Visit()
            {
                Id = dto.Id
            };
        }
    }
}

