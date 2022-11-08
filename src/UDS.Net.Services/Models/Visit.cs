using System;
namespace UDS.Net.Services.Models
{
    public class Visit
    {
        public int Id { get; set; }

        public int ParticipationId { get; set; }

        public int Number { get; set; }

        public string Version { get; set; }

        public Participation Participation { get; set; }
    }
}

