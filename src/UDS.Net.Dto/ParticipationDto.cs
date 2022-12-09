using System;
using System.Collections.Generic;

namespace UDS.Net.Dto
{
    public class ParticipationDto : BaseDto
    {
        public string LegacyId { get; set; }

        public IEnumerable<VisitDto> Visits { get; set; }
    }
}

