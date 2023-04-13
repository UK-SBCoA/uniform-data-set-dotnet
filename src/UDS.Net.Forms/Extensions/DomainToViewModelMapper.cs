using System;
using UDS.Net.Forms.Models;
using UDS.Net.Forms.Models.UDS3;
using UDS.Net.Services.DomainModels;
using UDS.Net.Services.DomainModels.Forms;

namespace UDS.Net.Forms.Extensions
{
    public static class DomainToViewModelMapper
    {
        public static ParticipationModel ToVM(this Participation participation)
        {
            return new ParticipationModel()
            {
                Id = participation.Id,
                LegacyId = participation.LegacyId,
                VisitCount = participation.Visits.Count(),
                Visits = participation.Visits.ToVM()
            };
        }

        public static List<VisitModel> ToVM(this IList<Visit> visits)
        {
            List<VisitModel> vm = new List<VisitModel>();

            foreach (var visit in visits)
            {
                vm.Add(visit.ToVM());
            }

            return vm;
        }

        public static VisitModel ToVM(this Visit visit)
        {
            return new VisitModel()
            {
                Id = visit.Id,
                ParticipationId = visit.ParticipationId,
                Number = visit.Number,
                Version = visit.Version,
                Kind = visit.Kind,
                StartDateTime = visit.StartDateTime,
                Forms = visit.Forms.ToVM()
            };
        }

        public static List<FormModel> ToVM(this IList<Form> forms)
        {
            List<FormModel> vm = new List<FormModel>();

            foreach (var form in forms)
            {
                vm.Add(form.ToVM());
            }

            return vm;
        }

        public static FormModel ToVM(this Form form)
        {
            var formModel = new FormModel()
            {
                VisitId = form.VisitId,
                Version = form.Version,
                Status = "",
                Title = form.Title,
                Description = form.Description,
                IsRequiredForVisitKind = false,
                IncludeInPacketSubmission = false
            };

            if (form.Fields is UDS3_IVP_A1)
            {
                var fields = (UDS3_IVP_A1)form.Fields;

                return new A1()
                {
                    VisitId = form.VisitId,
                    Version = form.Version,
                    Status = form.Status, // TODO
                    Title = form.Title,
                    Description = form.Description,
                    IsRequiredForVisitKind = false, // TODO
                    IncludeInPacketSubmission = form.IsIncluded.HasValue ? form.IsIncluded.Value : false, // TODO
                    ReasonNotIncluded = form.ReasonCode,
                    BIRTHMO = fields.BIRTHMO,
                    BIRTHYR = fields.BIRTHYR,
                    SEX = fields.SEX,
                    MARISTAT = fields.MARISTAT,
                    LIVSITUA = fields.LIVSITUA,
                    INDEPEND = fields.INDEPEND,
                    RESIDENC = fields.RESIDENC,
                    IVP = new A1_IVP()
                    {
                        REASON = fields.REASON,
                        REFERSC = fields.REFERSC,
                        LEARNED = fields.LEARNED,
                        PRESTAT = fields.PRESTAT,
                        PRESPART = fields.PRESPART,
                        SOURCENW = fields.SOURCENW,
                        HISPANIC = fields.HISPANIC,
                        HISPOR = fields.HISPOR,
                        HISPORX = fields.HISPORX,
                        RACE = fields.RACE,
                        RACEX = fields.RACEX,
                        RACESEC = fields.RACESEC,
                        RACESECX = fields.RACESECX,
                        RACETER = fields.RACETER,
                        RACETERX = fields.RACETERX,
                        PRIMLANG = fields.PRIMLANG,
                        PRIMLANX = fields.PRIMLANX,
                        EDUC = fields.EDUC,
                        ZIP = fields.ZIP,
                        HANDED = fields.HANDED
                    }
                };
            }

            return formModel;
        }

    }
}

