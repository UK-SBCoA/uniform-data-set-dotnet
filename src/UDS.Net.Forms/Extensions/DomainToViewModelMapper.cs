using System;
using UDS.Net.Dto;
using UDS.Net.Forms.Models;
using UDS.Net.Services.DomainModels;

namespace UDS.Net.Forms.Extensions
{
    public static class DomainToViewModelMapper
    {
        public static ParticipationViewModel ToVM(this Participation participation)
        {
            return new ParticipationViewModel()
            {
                Id = participation.Id,
                LegacyId = participation.LegacyId,
                VisitCount = participation.Visits.Count(),
                Visits = participation.Visits.ToVM()
            };
        }

        public static List<VisitViewModel> ToVM(this List<Visit> visits)
        {
            List<VisitViewModel> vm = new List<VisitViewModel>();

            foreach (var visit in visits)
            {
                vm.Add(visit.ToVM());
            }

            return vm;
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

        //public static List<FormViewModel> ToVM(this List<Form> forms)
        //{

        //}
    }
}

