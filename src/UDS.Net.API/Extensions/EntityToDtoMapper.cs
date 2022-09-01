using System;
using UDS.Net.API.Entities;
using UDS.Net.Dto;

namespace UDS.Net.API.Extensions
{
    public static class EntityToDtoMapper
    {
        public static VisitDto ToDto(this Visit visit)
        {
            return new VisitDto()
            {
                Id = visit.Id,
                ParticipationId = visit.ParticipationId,
                CreatedAt = visit.CreatedAt,
                CreatedBy = visit.CreatedBy,
                ModifiedBy = visit.ModifiedBy,
                DeletedBy = visit.DeletedBy,
                IsDeleted = visit.IsDeleted
            };
        }
    }
}

