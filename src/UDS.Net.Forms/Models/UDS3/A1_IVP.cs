using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using UDS.Net.Forms.TagHelpers;

namespace UDS.Net.Forms.Models.UDS3
{
    /// <summary>
    /// https://files.alz.washington.edu/documentation/uds3-ivp-a1.pdf
    /// </summary>
    public class A1_IVP : FormModel
    {
        public List<RadioListItem> ParticipationReasonsListItems { get; } = new List<RadioListItem>
        {
            new RadioListItem("To participate in a research study", "1"),
            new RadioListItem("To have clinical evaluation", "2"),
            new RadioListItem("Both (to participate in a research study and to have clinical evaluation", "4"),
            new RadioListItem("Unknown", "9")
        };

        public List<RadioListItem> ReferralSourcesListItems { get; } = new List<RadioListItem>
        {
            new RadioListItem("Self-referral", "1", "LEARNED"),
            new RadioListItem("Non-professional contact (spouse/partner, relative, friend, coworker, etc.)", "2", "LEARNED"),
            new RadioListItem("ADC participant referral", "3"),
            new RadioListItem("ADC clinician, staff, or investigator referral", "4"),
            new RadioListItem("Nurse, doctor, or other health care provider", "5"),
            new RadioListItem("Other research study clinician/staff/investigator (non-ADC; e.g., ADNI, Women's Health Initiative)", "6"),
            new RadioListItem("Other", "8"),
            new RadioListItem("Unknown", "9")
        };

        public List<RadioListItem> SecondaryReferralSourcesListItems { get; } = new List<RadioListItem>
        {
            new RadioListItem("ADC advertisement (e.g., website, mailing, newspaper ad, community presentation)", "1"),
            new RadioListItem("News article or TV program mentioning the ADC study", "2"),
            new RadioListItem("Conference or community event (e.g., community memory walk)", "3"),
            new RadioListItem("Another organization's media appeal or website", "4"),
            new RadioListItem("Other", "8"),
            new RadioListItem("Unknown", "9")
        };

        public List<RadioListItem> DiseaseStatusesListItems { get; } = new List<RadioListItem>
        {
            new RadioListItem("Case, patient, or proband", "1"),
            new RadioListItem("Control or normal", "2"),
            new RadioListItem("No presumed disease status", "3")
        };

        public List<RadioListItem> ParticipationsListItems { get; } = new List<RadioListItem>
        {
            new RadioListItem("Initial evaluation only", "1"),
            new RadioListItem("Longitudinal follow-up planned", "2")
        };

        public List<RadioListItem> EnrollmentTypesListItems { get; } = new List<RadioListItem>
        {
            new RadioListItem("Primarily ADC-funded (Clinical Core, Satellite Core, or other ADC Core or project)", "1"),
            new RadioListItem("Participant is supported primarily by a non-ADC study (e.g., R01, including non-ADC grants supporting FTLD Module participation)", "2")
        };

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

        [Display(Name = "ADC enrollment type")]
        [Range(1, 2)]
        public int? SOURCENW { get; set; }

    }
}

