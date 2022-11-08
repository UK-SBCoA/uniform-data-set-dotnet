using System;
using UDS.Net.Dto;
using UDS.Net.Forms.Models;
using UDS.Net.Services.Models;

namespace UDS.Net.Forms.Extensions
{
    public static class EntityToViewModelMapper
    {
        public static VisitViewModel ToVM(this Visit visit)
        {
            return new VisitViewModel()
            {
                Id = visit.Id
            };
        }
    }
}

