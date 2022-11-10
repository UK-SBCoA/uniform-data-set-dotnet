using System;
namespace UDS.Net.Services.DomainModels
{
    /// <summary>
    /// Visit domain model
    /// </summary>
    public class Visit
    {
        public int Id { get; set; }

        public int ParticipationId { get; set; }

        public int Number { get; set; }

        public string Version { get; set; }

        public string Kind { get; set; }

        public Participation Participation { get; set; }
    }
}

