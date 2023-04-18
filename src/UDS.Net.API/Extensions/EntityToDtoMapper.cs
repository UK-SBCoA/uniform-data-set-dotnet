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

                        if (formKind == "A4")
                        {
                            if (visit.A4G != null && visit.A4Ds != null)
                                formDto = visit.A4G.ToFullDto(visit.A4Ds);
                        }

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

        private static void SetBaseFormProperties(this FormDto dto, Form form)
        {
            if (form != null)
            {
                dto.Kind = form.GetType().Name;

                dto.Id = form.Id;
                dto.CreatedAt = form.CreatedAt;
                dto.CreatedBy = form.CreatedBy;
                dto.ModifiedBy = form.ModifiedBy;
                dto.DeletedBy = form.DeletedBy;
                dto.IsDeleted = form.IsDeleted;
                dto.VisitId = form.VisitId;
                dto.Status = form.Status;
                dto.Language = form.Language.HasValue ? form.Language.Value.ToString() : "";
                dto.IsIncluded = form.IsIncluded;
                dto.ReasonCode = form.ReasonCode.HasValue ? form.ReasonCode.Value.ToString() : "";
            }
        }

        public static A1Dto ToFullDto(this A1 a1)
        {
            A1Dto dto = new A1Dto
            {
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
                HANDED = a1.HANDED
            };
            dto.SetBaseFormProperties(a1);

            return dto;
        }

        public static A2Dto ToFullDto(this A2 a2)
        {
            A2Dto dto = new A2Dto
            {
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
            dto.SetBaseFormProperties(a2);
            return dto;
        }

        public static A3Dto ToFullDto(this A3 a3)
        {
            A3Dto dto = new A3Dto
            {
                AFFFAMM = a3.AFFFAMM,
                NWINFMUT = a3.NWINFMUT,
                FADMUT = a3.FADMUT,
                FADMUTX = a3.FADMUTX,
                FADMUSO = a3.FADMUSO,
                FADMUSOX = a3.FADMUSOX,
                FFTDMUT = a3.FFTDMUT,
                FFTDMUTX = a3.FFTDMUTX,
                FOTHMUT = a3.FOTHMUT,
                FOTHMUTX = a3.FOTHMUTX,
                MOMMOB = a3.MOMMOB,
                MOMYOB = a3.MOMYOB,
                MOMDAGE = a3.MOMDAGE,
                MOMNEUR = a3.MOMNEUR,
                MOMMOE = a3.MOMMOE,
                MOMAGEO = a3.MOMAGEO,
                DADMOB = a3.DADMOB,
                DADYOB = a3.DADYOB,
                DADDAGE = a3.DADDAGE,
                DADNEUR = a3.DADNEUR,
                DADPRDX = a3.DADPRDX,
                DADMOE = a3.DADMOE,
                DADAGEO = a3.DADAGEO,
                SIBS = a3.SIBS,
                SIB1 = a3.SIB1.ToFullDto(a3.Id),
                SIB2 = a3.SIB2.ToFullDto(a3.Id),
                SIB3 = a3.SIB3.ToFullDto(a3.Id),
                SIB4 = a3.SIB4.ToFullDto(a3.Id),
                SIB5 = a3.SIB5.ToFullDto(a3.Id),
                SIB6 = a3.SIB6.ToFullDto(a3.Id),
                SIB7 = a3.SIB7.ToFullDto(a3.Id),
                SIB8 = a3.SIB8.ToFullDto(a3.Id),
                SIB9 = a3.SIB9.ToFullDto(a3.Id),
                SIB10 = a3.SIB10.ToFullDto(a3.Id),
                SIB11 = a3.SIB11.ToFullDto(a3.Id),
                SIB12 = a3.SIB12.ToFullDto(a3.Id),
                SIB13 = a3.SIB13.ToFullDto(a3.Id),
                SIB14 = a3.SIB14.ToFullDto(a3.Id),
                SIB15 = a3.SIB15.ToFullDto(a3.Id),
                SIB16 = a3.SIB16.ToFullDto(a3.Id),
                SIB17 = a3.SIB17.ToFullDto(a3.Id),
                SIB18 = a3.SIB18.ToFullDto(a3.Id),
                SIB19 = a3.SIB19.ToFullDto(a3.Id),
                SIB20 = a3.SIB20.ToFullDto(a3.Id),
                KIDS = a3.KIDS,
                KID1 = a3.KID1.ToFullDto(a3.Id),
                KID2 = a3.KID2.ToFullDto(a3.Id),
                KID3 = a3.KID3.ToFullDto(a3.Id),
                KID4 = a3.KID4.ToFullDto(a3.Id),
                KID5 = a3.KID5.ToFullDto(a3.Id),
                KID6 = a3.KID6.ToFullDto(a3.Id),
                KID7 = a3.KID7.ToFullDto(a3.Id),
                KID8 = a3.KID8.ToFullDto(a3.Id),
                KID9 = a3.KID9.ToFullDto(a3.Id),
                KID10 = a3.KID10.ToFullDto(a3.Id),
                KID11 = a3.KID11.ToFullDto(a3.Id),
                KID12 = a3.KID12.ToFullDto(a3.Id),
                KID13 = a3.KID13.ToFullDto(a3.Id),
                KID14 = a3.KID14.ToFullDto(a3.Id),
                KID15 = a3.KID15.ToFullDto(a3.Id)
            };
            dto.SetBaseFormProperties(a3);

            return dto;
        }

        public static A3FamilyMemberDto ToFullDto(this A3FamilyMember a3FamilyMember, int formId)
        {
            if (a3FamilyMember != null)
            {
                return new A3FamilyMemberDto
                {
                    FormId = formId,
                    MOB = a3FamilyMember.MOB,
                    YOB = a3FamilyMember.YOB,
                    AGD = a3FamilyMember.AGD,
                    NEU = a3FamilyMember.NEU,
                    PDX = a3FamilyMember.PDX,
                    MOE = a3FamilyMember.MOE,
                    AGO = a3FamilyMember.AGO
                };
            }
            else
                return new A3FamilyMemberDto();
        }

        public static A4GDto ToFullDto(this A4G a4G, IEnumerable<A4D> a4Ds)
        {
            A4GDto dto = new A4GDto
            {
                ANYMEDS = a4G.ANYMEDS,
                A4Dtos = a4Ds.Select(a => a.ToFullDto()).ToList()
            };
            dto.SetBaseFormProperties(a4G);
            return dto;
        }

        public static A4DDto ToFullDto(this A4D a4D)
        {
            A4DDto dto = new A4DDto
            {
                DRUGID = a4D.DRUGID
            };
            dto.SetBaseFormProperties(a4D);
            return dto;
        }

        public static A5Dto ToFullDto(this A5 a5)
        {
            A5Dto dto = new A5Dto
            {
                TOBAC30 = a5.TOBAC30,
                TOBAC100 = a5.TOBAC100,
                SMOKYRS = a5.SMOKYRS,
                PACKSPER = a5.PACKSPER,
                QUITSMOK = a5.QUITSMOK,
                ALCOCCAS = a5.ALCOCCAS,
                ALCFREQ = a5.ALCFREQ,
                CVHATT = a5.CVHATT,
                HATTMULT = a5.HATTMULT,
                HATTYEAR = a5.HATTYEAR,
                CVAFIB = a5.CVAFIB,
                CVANGIO = a5.CVANGIO,
                CVBYPASS = a5.CVBYPASS,
                CVPACDEF = a5.CVPACDEF,
                CVCHF = a5.CVCHF,
                CVANGINA = a5.CVANGINA,
                CVHVALVE = a5.CVHVALVE,
                CVOTHR = a5.CVOTHR,
                CVOTHRX = a5.CVOTHRX,
                CBSTROKE = a5.CBSTROKE,
                STROKMUL = a5.STROKMUL,
                CBTIA = a5.CBTIA,
                TIAMULT = a5.TIAMULT,
                TIAYEAR = a5.TIAYEAR,
                PD = a5.PD,
                PDYR = a5.PDYR,
                PDOTHR = a5.PDOTHR,
                PDOTHRYR = a5.PDOTHRYR,
                SEIZURES = a5.SEIZURES,
                TBI = a5.TBI,
                TBIBRIEF = a5.TBIBRIEF,
                TBIEXTEN = a5.TBIEXTEN,
                TBIWOLOS = a5.TBIWOLOS,
                TBIYEAR = a5.TBIYEAR,
                DIABETES = a5.DIABETES,
                DIABTYPE = a5.DIABTYPE,
                HYPERTEN = a5.HYPERTEN,
                HYPERCHO = a5.HYPERCHO,
                B12DEF = a5.B12DEF,
                THYROID = a5.THYROID,
                ARTHRIT = a5.ARTHRIT,
                ARTHTYPE = a5.ARTHTYPE,
                ARTHTYPX = a5.ARTHTYPX,
                ARTHUPEX = a5.ARTHUPEX,
                ARTHLOEX = a5.ARTHLOEX,
                ARTHSPIN = a5.ARTHSPIN,
                ARTHUNK = a5.ARTHUNK,
                INCONTU = a5.INCONTU,
                INCONTF = a5.INCONTF,
                APNEA = a5.APNEA,
                RBD = a5.RBD,
                INSOMN = a5.INSOMN,
                OTHSLEEP = a5.OTHSLEEP,
                OTHSLEEX = a5.OTHSLEEX,
                ALCOHOL = a5.ALCOHOL,
                ABUSOTHR = a5.ABUSOTHR,
                ABUSX = a5.ABUSX,
                PTSD = a5.PTSD,
                BIPOLAR = a5.BIPOLAR,
                SCHIZ = a5.SCHIZ,
                DEP2YRS = a5.DEP2YRS,
                DEPOTHR = a5.DEPOTHR,
                ANXIETY = a5.ANXIETY,
                OCD = a5.OCD,
                NPSYDEV = a5.NPSYDEV,
                PSYCDIS = a5.PSYCDIS,
                PSYCDISX = a5.PSYCDISX
            };
            dto.SetBaseFormProperties(a5);
            return dto;
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

