using System;
using UDS.Net.Dto;
using UDS.Net.Forms.Models;
using UDS.Net.Services.Models;

namespace UDS.Net.Forms.Extensions
{
    public static class ViewModelToEntityMapper
    {
        public static Visit ToEntity(this VisitViewModel vm)
        {
            return new Visit();
        }
    }
}

