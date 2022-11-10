using System;
using UDS.Net.Dto;
using UDS.Net.Forms.Models;
using UDS.Net.Services.DomainModels;

namespace UDS.Net.Forms.Extensions
{
    public static class ViewModelToDomainMapper
    {
        public static Participation ToEntity(this ParticipationViewModel vm)
        {
            return new Participation
            {
                Id = vm.Id,
                LegacyId = vm.LegacyId
            };
        }

        public static Visit ToEntity(this VisitViewModel vm)
        {
            return new Visit(vm.Version, vm.Kind);
        }

    }
}

