using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using UDS.Net.Forms.TagHelpers;

namespace UDS.Net.Forms.Models.UDS3
{
    public class A1_EthnicGroup
    {
        public List<RadioListItem> HispanicLatinoListItems { get; } = new List<RadioListItem>
        {
            new RadioListItem("No  (If No, SKIP TO QUESTION 9)", "1"),
            new RadioListItem("Yes", "2"),
            new RadioListItem("Unknown (If Unknown, SKIP TO QUESTION 9)", "9")
        };

        public List<RadioListItem> OriginsListItems { get; } = new List<RadioListItem>
        {
            new RadioListItem("Mexican, Chicano, or Mexican-American", "1"),
            new RadioListItem("Puerto Rican", "2"),
            new RadioListItem("Cuban", "3"),
            new RadioListItem("Dominican", "4"),
            new RadioListItem("Central American", "5"),
            new RadioListItem("South American", "6"),
            new RadioListItem("Other (specify)", "50"),
            new RadioListItem("Unknown","99")
        };

        [Display(Name = "Does the participant report being of Hispanic/Latino ethnicity (i.e., having origins from a mainly Spanish-speaking Latin American country), regardless of race?")]
        [Range(0, 9)]
        public int? HISPANIC { get; set; }

        [Display(Name = "If yes, what are the participant's reported origins?")]
        [Range(1, 99)]
        public int? HISPOR { get; set; }

        [Display(Name = "Other (specify)")]
        [Column("HISPORX")]
        [StringLength(60)]
        public string HISPORX { get; set; } = string.Empty;
    }
}

