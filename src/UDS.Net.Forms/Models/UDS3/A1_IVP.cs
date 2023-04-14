using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.Forms.Models.UDS3
{
    /// <summary>
    /// https://files.alz.washington.edu/documentation/uds3-ivp-a1.pdf
    /// </summary>
    public class A1_IVP : FormModel
    {
        public Dictionary<int, string> ParticipationReasons { get; } = new Dictionary<int, string>
        {
            { 1, "To participate in a research study" },
            { 2, "To have clinical evaluation" },
            { 3, "Both (to participate in a reasearch study and to have a clinical evaluation)" },
            { 4, "Unknown" }
        };

        public Dictionary<int, string> ReferralSource { get; } = new Dictionary<int, string>();

        [Display(Name = "Primary reason for coming to ADC")]
        [Range(1, 9)]
        public int? REASON { get; set; }

        [Display(Name = "Principal referral source")]
        [Range(1, 9)]
        public int? REFERSC { get; set; }

        [Display(Name = "If the referral source was self-referral or a non-professional contact, how did the referral source learn of the ADC?")]
        [Range(1, 9)]
        public int? LEARNED { get; set; }

        [Display(Name = "Presumed disease status at enrollment")]
        [Range(1, 3)]
        public int? PRESTAT { get; set; }

        [Display(Name = "Presumed participation")]
        [Range(1, 2)]
        public int? PRESPART { get; set; }

        [Display(Name = "ADC enrollment type:")]
        [Range(1, 2)]
        public int? SOURCENW { get; set; }

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

        [Display(Name = "Participant’s primary language")]
        [Range(1, 9)]
        public int? PRIMLANG { get; set; }

        [Display(Name = "Other (specify)")]
        [StringLength(60)]
        public string PRIMLANX { get; set; } = string.Empty;

        [Display(Name = "Participant’s years of education, use the codes below to report the level achieved; if an attempted level is not completed, enter the number of years completed")]
        [Range(0, 99)]
        public int? EDUC { get; set; }

        [Display(Name = "ZIP Code (first three digits) of participant’s primary residence")]
        //[Range(006, 999)]
        public string ZIP { get; set; } = string.Empty;

        [Display(Name = "Is the participant left- or right-handed (for example, which hand would s/ he normally use to write or throw a ball)?")]
        [Range(1, 9)]
        public int? HANDED { get; set; }

        public A1_IVP()
        {
            // REFERSC
            ReferralSource.Add(1, "Self-referral");
            ReferralSource.Add(2, "Non-professional contact (spouse/partner, relative, friend, coworker, etc.)");
            ReferralSource.Add(3, "ADC participant referral");
        }
    }
}

