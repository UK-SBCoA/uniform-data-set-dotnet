using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace UDS.Net.Forms.Models.UDS3
{
    public class A1_RacialGroup
    {
        [Display(Name = "What does the participant report as his or her race?")]
        [Range(1, 99)]
        public int? RACE { get; set; }

        [Display(Name = "Other (specify)")]
        [StringLength(60)]
        public string RACEX { get; set; } = string.Empty;

        [Display(Name = "What additional race does participant report?")]
        [Range(1, 99)]
        public int? RACESEC { get; set; }

        [Display(Name = "Other (specify)")]
        [StringLength(60)]
        public string RACESECX { get; set; } = string.Empty;

        [Display(Name = "What additional race, beyond those reported in Questions 9 and 10, does participant report?")]
        [Range(1, 99)]
        public int? RACETER { get; set; }

        [Display(Name = "Other (specify)")]
        [StringLength(60)]
        public string? RACETERX { get; set; }
    }
}

