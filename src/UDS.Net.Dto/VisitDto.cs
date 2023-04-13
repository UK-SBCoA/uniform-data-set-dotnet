using System;
using System.Collections.Generic;

namespace UDS.Net.Dto
{
    public class VisitDto : BaseDto
    {
        public int ParticipationId { get; set; }

        public int Number { get; set; }

        public string Kind { get; set; } = "";

        public string Version { get; set; } = "";

        public DateTime StartDateTime { get; set; }

        public List<FormDto> Forms { get; set; }
    }
}

