
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using UDS.Net.Forms.TagHelpers;

namespace UDS.Net.Forms.Models.UDS3
{
    public class A2 : FormModel
    {
        public List<RadioListItem> HispanicLatinoListItems { get; } = new List<RadioListItem>
        {
            new RadioListItem("No  (If No, SKIP TO QUESTION 5)", "1"),
            new RadioListItem("Yes", "2"),
            new RadioListItem("Unknown (If Unknown, SKIP TO QUESTION 5)", "9")
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

        public List<RadioListItem> RacialGroupListItems { get; set; } = new List<RadioListItem>
        {
            new RadioListItem("White", "1"),
            new RadioListItem("Black or African American", "2"),
            new RadioListItem("American Indian or Alaska Native", "3"),
            new RadioListItem("Native Hawaiian or other Pacific Islander", "4"),
            new RadioListItem("Asian", "5"),
            new RadioListItem("Other (specify)", "50"),
            new RadioListItem("Unknown", "99")
        };

        [Display(Name = "Co-participant's birth month")]
        [Range(1, 99, ErrorMessage = "Birth month must be within 1 and 99")]
        public int? INBIRMO { get; set; }

        [Display(Name = "Co-participant's birth year")]
        [Range(1900, 9999, ErrorMessage = "Birth year must be within 1900 and 9999")]
        public int? INBIRYR { get; set; }

        [Display(Name = "Co-participant's sex")]
        public int? INSEX { get; set; }

        [Display(Name = "Does the co-participant report being of Hispanic/Latino ethnicity  (i.e., having origins from a mainly Spanish-speaking Latin American country), regardless of race?")]
        public int? INHISP { get; set; }

        [Display(Name = "If yes, what are the co-participant's reported origins?")]
        public int? INHISPOR { get; set; }

        [Display(Name = "Other (SPECIFY)")]
        [MaxLength(60)]
        public string INHISPOX { get; set; }

        [Display(Name = "What does the co-participant report as his or her race?")]
        public int? INRACE { get; set; }

        [Display(Name = "Other (SPECIFY)")]
        [MaxLength(60)]
        public string INRACEX { get; set; }

        [Display(Name = "What additional race does the co-participant report?")]
        public int? INRASEC { get; set; }

        [Display(Name = "Other (SPECIFY)")]
        [MaxLength(60)]
        public string INRASECX { get; set; }

        [Display(Name = "What additional race, beyond those reported in Questions 4 and 5, does the co-participant report?")]
        public int? INRATER { get; set; }

        [Display(Name = "Other (SPECIFY)")]
        [MaxLength(60)]
        public string INRATERX { get; set; }

        [Display(Name = "Co-participant's years of education — use the codes below to report the level achieved; if an attempted level is not completed, enter the number of years completed")]
        [Range(0, 99, ErrorMessage = "Co-participants years of education must be within 0 and 99")]
        public int? INEDUC { get; set; }

        [Display(Name = "What is the co-participant's relationship to the participant?")]
        public int? INRELTO { get; set; }

        [Display(Name = "How long has the co-participant known the participant?")]
        [Range(0, 999, ErrorMessage = "Years known must be within 0 and 999")]
        public int? INKNOWN { get; set; }

        [Display(Name = "Does the co-participant live with the subject?")]
        public int? INLIVWTH { get; set; }

        [Display(Name = "If no, approximate frequency of in-person visits?")]
        public int? INVISITS { get; set; }

        [Display(Name = "If no, approximate frequency of telephone contact?")]
        public int? INCALLS { get; set; }

        [Display(Name = "Is there a question about the co-participant's reliability?")]
        public int? INRELY { get; set; }
    }
}

