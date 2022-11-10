using System;
using System.Collections.Generic;

namespace UDS.Net.Services.DomainModels
{
    public class Participation
    {
        public int Id { get; set; }

        public string LegacyId { get; set; }

        public IList<Visit> Visits { get; set; } = new List<Visit>();
    }
}

