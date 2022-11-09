﻿using System;
using System.ComponentModel.DataAnnotations;

namespace UDS.Net.Forms.Models
{
    public class ParticipationViewModel
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Display(Name = "Legacy Id")]
        public string LegacyId { get; set; }

        public int VisitCount { get; set; }
    }
}

