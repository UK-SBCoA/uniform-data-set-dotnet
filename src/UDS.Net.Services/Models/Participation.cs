using System;
using System.Collections.Generic;

namespace UDS.Net.Services.Models
{
    public class Participation
    {
        public int Id { get; set; }

        public string LegacyId { get; set; }

        public List<Visit> Visits { get; set; }
    }
}

