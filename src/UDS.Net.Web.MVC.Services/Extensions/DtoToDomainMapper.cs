﻿using System;
using UDS.Net.Dto;
using UDS.Net.Services.DomainModels;

namespace UDS.Net.Services.Extensions
{
    public static class DtoToDomainMapper
    {
        public static Visit ToDomain(this VisitDto dto)
        {
            return new Visit("UDS3", "IVP")
            {
                Id = dto.Id
            };
        }
    }
}
