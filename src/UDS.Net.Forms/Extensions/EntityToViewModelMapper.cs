using System;
using UDS.Net.Dto;
using UDS.Net.Forms.Models;
using UDS.Net.Services.Models;

namespace UDS.Net.Forms.Extensions
{
    public static class EntityToViewModelMapper
    {
        public static ParticipationViewModel ToVM(this Participation participation)
        {
            return new ParticipationViewModel()
            {
                Id = participation.Id,
                LegacyId = participation.LegacyId,
                VisitCount = participation.Visits.Count()
            };
        }

        public static VisitViewModel ToVM(this Visit visit)
        {
            return new VisitViewModel()
            {
                Id = visit.Id,
                ParticipationId = visit.ParticipationId,
                Number = visit.Number,
                Version = visit.Version,
                Kind = visit.Kind
            };
        }
    }
}

