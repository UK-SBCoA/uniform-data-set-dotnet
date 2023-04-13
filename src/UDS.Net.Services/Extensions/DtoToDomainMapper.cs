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
        public static Visit ToDomain(this VisitDto dto)
        {
            var visit = new Visit(dto.Version, dto.Kind)
            {
                Id = dto.Id,
                Number = dto.Number,
                ParticipationId = dto.ParticipationId,
                Version = dto.Version,
                StartDateTime = dto.StartDateTime
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
                    return new Form(visit, dto.Kind, new UDS3_IVP_A1(dto));
                }
                else if (dto is A2Dto)
                {
                    return new Form(visit, dto.Kind, new UDS3_IVP_A1()); // TODO map to A2
                }
                else if (dto is FormDto)
                {
                    return new Form(visit, dto.Kind, new UDS3_IVP_A1()); // TODO map to generic form
                }
            }

            throw new Exception("Form cannot be converted.");
        }

    }
}

