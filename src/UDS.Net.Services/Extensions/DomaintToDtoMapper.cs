using System;
using System.Collections.Generic;
using System.Linq;
using UDS.Net.Dto;
using UDS.Net.Services.DomainModels;
using UDS.Net.Services.DomainModels.Forms;

namespace UDS.Net.Services.Extensions
{
    public static class DomaintToDtoMapper
    {
        public static VisitDto ToDto(this Visit visit)
        {
            return new VisitDto()
            {
                Id = visit.Id,
                ParticipationId = visit.ParticipationId,
                Number = visit.Number,
                Version = visit.Version,
                Kind = visit.Kind,
                StartDateTime = visit.StartDateTime,
                CreatedAt = visit.CreatedAt,
                CreatedBy = visit.CreatedBy,
                ModifiedBy = visit.ModifiedBy,
                DeletedBy = visit.DeletedBy,
                IsDeleted = visit.IsDeleted,
                Forms = visit.Forms.ToDto()
            };
        }

        public static List<FormDto> ToDto(this IList<Form> forms)
        {
            return forms.Select(f => f.ToDto()).ToList();
        }

        public static FormDto ToDto(this Form form)
        {
            if (form.Fields is A1FormFields)
            {
                var fields = (A1FormFields)form.Fields;
                return new A1Dto()
                {
                    Id = form.Id,
                    VisitId = form.VisitId,
                    Kind = form.Kind,
                    Status = form.Status,
                    Language = form.Language,
                    IsIncluded = form.IsIncluded,
                    ReasonCode = form.ReasonCode,
                    REASON = fields.REASON,
                    REFERSC = fields.REFERSC,
                    LEARNED = fields.LEARNED,
                    PRESTAT = fields.PRESTAT,
                    PRESPART = fields.PRESPART,
                    SOURCENW = fields.SOURCENW,
                    BIRTHMO = fields.BIRTHMO,
                    BIRTHYR = fields.BIRTHYR,
                    SEX = fields.SEX,
                    MARISTAT = fields.MARISTAT,
                    LIVSITUA = fields.LIVSITUA,
                    INDEPEND = fields.INDEPEND,
                    RESIDENC = fields.RESIDENC,
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
                };
            }

            return new FormDto()
            {
                Id = form.Id,
                VisitId = form.VisitId,
                Kind = form.Kind,
                Status = form.Status,
                Language = form.Language,
                IsIncluded = form.IsIncluded,
                ReasonCode = form.ReasonCode
            };
        }
    }
}

