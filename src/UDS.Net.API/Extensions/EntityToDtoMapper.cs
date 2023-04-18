using System;
using UDS.Net.API.Entities;
using UDS.Net.Dto;

namespace UDS.Net.API.Extensions
{
    public static class EntityToDtoMapper
    {
        private static VisitDto ConvertVisitToDto(Visit visit)
        {
            var dto = new VisitDto()
            {
                Id = visit.Id,
                ParticipationId = visit.ParticipationId,
                CreatedAt = visit.CreatedAt,
                CreatedBy = visit.CreatedBy,
                ModifiedBy = visit.ModifiedBy,
                DeletedBy = visit.DeletedBy,
                IsDeleted = visit.IsDeleted,
                Number = visit.Number,
                Kind = visit.Kind,
                Version = visit.Version,
                StartDateTime = visit.StartDateTime,
                Forms = new List<FormDto>()
            };

            return dto;
        }

        public static VisitDto ToDto(this Visit visit)
        {
            var dto = ConvertVisitToDto(visit);

            if (visit.FormStatuses != null)
            {
                // since we aren't returning any specific details of any form, return the summary and status of all
                foreach (var formStatus in visit.FormStatuses.OrderBy(f => f.Kind).ToList()) // TODO Instead of ordering alphabetically by kind, include a DisplayWeight property and make it configurable (maybe even grouping)
                {
                    dto.Forms.Add(new FormDto
                    {
                        Id = formStatus.Id,
                        VisitId = formStatus.VisitId,
                        Status = formStatus.Status,
                        Kind = formStatus.Kind,
                        IsDeleted = formStatus.IsDeleted,
                        DeletedBy = formStatus.DeletedBy,
                        CreatedBy = formStatus.CreatedBy,
                        CreatedAt = formStatus.CreatedAt,
                        IsIncluded = formStatus.IsIncluded,
                        Language = formStatus.Language.HasValue ? formStatus.Language.Value.ToString() : "",
                        ModifiedBy = formStatus.ModifiedBy,
                        ReasonCode = formStatus.ReasonCode.HasValue ? formStatus.ReasonCode.Value.ToString() : ""
                    });
                }
            }

            return dto;
        }

        public static VisitDto ToDto(this Visit visit, string formKind)
        {
            var dto = ConvertVisitToDto(visit);

            // Attach form based on kind
            if (!String.IsNullOrWhiteSpace(formKind))
            {
                foreach (var form in visit.FormStatuses)
                {
                    FormDto formDto = new FormDto();

                    if (form.Kind == formKind)
                    {
                        if (formKind == "A1" && visit.A1 != null)
                            formDto = visit.A1.ToFullDto();

                        if (formKind == "A2" && visit.A2 != null)
                            formDto = visit.A2.ToFullDto();

                        if (formKind == "A3" && visit.A3 != null)
                            formDto = visit.A3.ToFullDto();

                        if (formKind == "A4" && visit.A4G != null)
                            formDto = visit.A4G.ToFullDto();

                        if (formKind == "A5" && visit.A5 != null)
                            formDto = visit.A5.ToFullDto();
                    }
                    else
                    {
                        formDto = new FormDto
                        {
                            Id = form.Id,
                            VisitId = form.VisitId,
                            Kind = form.Kind,
                            Status = form.Status,
                            CreatedAt = form.CreatedAt,
                            CreatedBy = form.CreatedBy,
                            ModifiedBy = form.ModifiedBy,
                            DeletedBy = form.DeletedBy,
                            IsDeleted = form.IsDeleted,
                            IsIncluded = form.IsIncluded,
                            Language = form.Language.HasValue ? form.Language.Value.ToString() : "",
                            ReasonCode = form.ReasonCode.HasValue ? form.ReasonCode.Value.ToString() : ""
                        };
                    }
                    dto.Forms.Add(formDto);
                }




            }

            return dto;
        }

        public static A1Dto ToFullDto(this A1 a1)
        {
            return new A1Dto
            {
                Id = a1.Id,
                Kind = a1.ToString(),
                VisitId = a1.VisitId,
                CreatedAt = a1.CreatedAt,
                CreatedBy = a1.CreatedBy,
                ModifiedBy = a1.ModifiedBy,
                REASON = a1.REASON,
                REFERSC = a1.REFERSC,
                LEARNED = a1.LEARNED,
                PRESTAT = a1.PRESTAT,
                PRESPART = a1.PRESPART,
                SOURCENW = a1.SOURCENW,
                BIRTHMO = a1.BIRTHMO,
                BIRTHYR = a1.BIRTHYR,
                SEX = a1.SEX,
                HISPANIC = a1.HISPANIC,
                HISPOR = a1.HISPOR,
                HISPORX = a1.HISPORX,
                RACE = a1.RACE,
                RACEX = a1.RACEX,
                RACESEC = a1.RACESEC,
                RACESECX = a1.RACESECX,
                RACETER = a1.RACETER,
                PRIMLANG = a1.PRIMLANG,
                EDUC = a1.EDUC,
                MARISTAT = a1.MARISTAT,
                LIVSITUA = a1.LIVSITUA,
                INDEPEND = a1.INDEPEND,
                RESIDENC = a1.RESIDENC,
                ZIP = a1.ZIP,
                HANDED = a1.HANDED,
                DeletedBy = a1.DeletedBy,
                IsDeleted = a1.IsDeleted
            };
        }

        public static A2Dto ToFullDto(this A2 a2)
        {
            return new A2Dto
            {
                Id = a2.Id,
                CreatedAt = a2.CreatedAt,
                CreatedBy = a2.CreatedBy,
                ModifiedBy = a2.ModifiedBy,
                INBIRMO = a2.INBIRMO,
                INBIRYR = a2.INBIRYR,
                INSEX = a2.INSEX,
                INHISP = a2.INHISP,
                INHISPOR = a2.INHISPOR,
                INHISPOX = a2.INHISPOX,
                INRACE = a2.INRACE,
                INRACEX = a2.INRACEX,
                INRASEC = a2.INRASEC,
                INRASECX = a2.INRASECX,
                INRATER = a2.INRATER,
                INRATERX = a2.INRATERX,
                INEDUC = a2.INEDUC,
                INRELTO = a2.INRELTO,
                INKNOWN = a2.INKNOWN,
                INLIVWTH = a2.INLIVWTH,
                INVISITS = a2.INVISITS,
                INCALLS = a2.INCALLS,
                INRELY = a2.INRELY
            };
        }

        public static A3Dto ToFullDto(this A3 a3)
        {
            // TODO A3 mapping
            return new A3Dto
            {
            };
        }

        public static A3FamilyMemberDto ToFullDto(this A3FamilyMember a3FamilyMember)
        {
            // TODO A3 mapping
            return new A3FamilyMemberDto
            {
            };
        }

        public static A4GDto ToFullDto(this A4G a4G)
        {
            // TODO A4 mapping
            return new A4GDto
            {
            };
        }

        public static A4DDto ToFullDto(this A4D a4D)
        {
            // TODO a4 mapping
            return new A4DDto
            {
            };
        }

        public static A5Dto ToFullDto(this A5 a5)
        {
            // TODO a5 mapping
            return new A5Dto
            {
            };
        }

        public static ParticipationDto ToDto(this Participation participation)
        {
            var dto = new ParticipationDto()
            {
                Id = participation.Id,
                LegacyId = participation.LegacyId,
                CreatedAt = participation.CreatedAt,
                CreatedBy = participation.CreatedBy,
                ModifiedBy = participation.ModifiedBy,
                DeletedBy = participation.DeletedBy,
                IsDeleted = participation.IsDeleted,
                Visits = participation.Visits.Select(v => v.ToDto()).ToList()
            };

            return dto;
        }
    }
}

