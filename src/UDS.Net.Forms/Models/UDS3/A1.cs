using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace UDS.Net.Forms.Models.UDS3
{
    public class A1 : FormModel
    {
        public A1_IVP IVP { get; set; } = default!;
        public A1_EthnicGroup EthnicGroup { get; set; } = default!;
        public A1_RacialGroup RacialGroup { get; set; } = default!;
        public A1_LangEdu LangEdu { get; set; } = default!;
        public A1_Zip Zip { get; set; } = default!;

        public A1_FVP FVP { get; set; } = default!;
        public A1_TIP TIP { get; set; } = default!;
        public A1_TFP TFP { get; set; } = default!;

        [Display(Name = "Participant’s month of birth")]
        [Range(1, 12)]
        public int? BIRTHMO { get; set; }

        [Display(Name = "Participant’s year of birth")]
        [Range(1875, 2006)]
        public int? BIRTHYR { get; set; }

        [Display(Name = "Participant’s sex")]
        [Range(1, 2)]
        public int? SEX { get; set; }

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

    }
}

