using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.Forms.Models.UDS3
{
    public class A1_IVP
    {
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

        [Display(Name = "Participant’s month of birth")]
        [Range(1, 12)]
        public int? BIRTHMO { get; set; }

        [Display(Name = "Participant’s year of birth")]
        [Range(1875, 2006)]
        public int? BIRTHYR { get; set; }

        [Display(Name = "Participant’s sex")]
        [Range(1, 2)]
        public int? SEX { get; set; }

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

        [Display(Name = "Participant’s current marital status")]
        [Range(0, 9)]
        public int? MARISTAT { get; set; }

        [Display(Name = "What is the participant’s living situation?")]
        [Range(0, 9)]
        public int? LIVSITUA { get; set; }

        [Display(Name = "What is the participant’s level of independence?")]
        [Range(0, 9)]
        public int? INDEPEND { get; set; }

        [Display(Name = "What is the participant’s primary type of residence?")]
        [Range(0, 9)]
        public int? RESIDENC { get; set; }

        [Display(Name = "ZIP Code (first three digits) of participant’s primary residence")]
        [Range(006, 999)]
        public int? ZIP { get; set; }

        [Display(Name = "Is the participant left- or right-handed (for example, which hand would s/ he normally use to write or throw a ball)?")]
        [Range(1, 9)]
        public int? HANDED { get; set; }
    }
}

