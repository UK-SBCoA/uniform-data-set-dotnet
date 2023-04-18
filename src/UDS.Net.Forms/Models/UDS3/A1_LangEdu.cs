using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace UDS.Net.Forms.Models.UDS3
{
    public class A1_LangEdu
    {

        [Display(Name = "Participant’s primary language")]
        [Range(1, 9)]
        public int? PRIMLANG { get; set; }

        [Display(Name = "Other (specify)")]
        [StringLength(60)]
        public string PRIMLANX { get; set; } = string.Empty;

        [Display(Name = "Participant’s years of education, use the codes below to report the level achieved; if an attempted level is not completed, enter the number of years completed")]
        [Range(0, 99)]
        public int? EDUC { get; set; }
    }
}

