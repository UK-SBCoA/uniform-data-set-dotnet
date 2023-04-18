using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace UDS.Net.Forms.Models.UDS3
{
    public class A1_Zip
    {
        [Display(Name = "ZIP Code (first three digits) of participant’s primary residence")]
        //[Range(006, 999)]
        public string ZIP { get; set; } = string.Empty;

        [Display(Name = "Is the participant left- or right-handed (for example, which hand would s/ he normally use to write or throw a ball)?")]
        [Range(1, 9)]
        public int? HANDED { get; set; }
    }
}

