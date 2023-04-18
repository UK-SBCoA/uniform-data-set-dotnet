using System;
using System.Collections.Generic;
using System.Linq;
using UDS.Net.Dto;
using UDS.Net.Services.DomainModels;
using UDS.Net.Services.DomainModels.Forms;

namespace UDS.Net.Services.Extensions
{
    public static class DtoToDomainMapper
    {
        public static Participation ToDomain(this ParticipationDto dto)
        {
            var participation = new Participation()
            {
                Id = dto.Id,
                LegacyId = dto.LegacyId,
                CreatedAt = dto.CreatedAt,
                CreatedBy = dto.CreatedBy,
                ModifiedBy = dto.ModifiedBy,
                DeletedBy = dto.DeletedBy,
                IsDeleted = dto.IsDeleted
            };

            if (dto.Visits != null)
            {
                participation.Visits = dto.Visits.Select(v => v.ToDomain()).ToList();
            }

            return participation;
        }

        public static Visit ToDomain(this VisitDto dto)
        {
            var visit = new Visit(dto.Version, dto.Kind)
            {
                Id = dto.Id,
                Number = dto.Number,
                ParticipationId = dto.ParticipationId,
                Version = dto.Version,
                StartDateTime = dto.StartDateTime,
                CreatedAt = dto.CreatedAt,
                CreatedBy = dto.CreatedBy,
                ModifiedBy = dto.ModifiedBy,
                DeletedBy = dto.DeletedBy,
                IsDeleted = dto.IsDeleted
            };

            if (dto.Forms != null)
            {
                visit.Forms = dto.Forms.ToDomain(visit);
            }

            return visit;
        }

        public static IList<Form> ToDomain(this List<FormDto> dto, Visit visit)
        {
            return dto.Select(f => f.ToDomain(visit)).ToList();
        }

        public static Form ToDomain(this FormDto dto, Visit visit)
        {
            if (visit.Kind == "IVP")
            {
                if (dto is A1Dto)
                {
                    return new Form(visit, dto.Id, "A1", dto.Kind, dto.Status, dto.Language, dto.IsIncluded, dto.ReasonCode, new UDS3_IVP_A1(dto));
                }
                else if (dto is A2Dto)
                {
                    return new Form(visit, dto.Id, "A2", dto.Kind, dto.Status, dto.Language, dto.IsIncluded, dto.ReasonCode, new UDS3_IVP_A1()); // TODO map to A2
                }
                else if (dto is FormDto)
                {
                    return new Form(visit, dto.Id, "", dto.Kind, dto.Status, dto.Language, dto.IsIncluded, dto.ReasonCode, new UDS3_IVP_A1()); // TODO map to generic form
                }
            }
            else if (visit.Kind == "FVP")
            {
                if (dto is A1Dto)
                {
                    return new Form(visit, dto.Id, "A1", dto.Kind, dto.Status, dto.Language, dto.IsIncluded, dto.ReasonCode, new UDS3_IVP_A1(dto));
                }
            }
            else if (visit.Kind == "TIP")
            {
            }
            else if (visit.Kind == "TFP")
            {
            }

            throw new Exception("Form cannot be converted.");
        }

    }
}

