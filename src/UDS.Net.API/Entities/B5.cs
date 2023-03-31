using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Neuropsychiatric Inventory Questionnaire (NPI–Q)
    /// </summary>
    [Table("tbl_B5s")]
    public class B5 : Form
	{
        public int? NPIQINF { get; set; }
        [MaxLength(60)]
        public string? NPIQINFX { get; set; }
        public int? DEL { get; set; }
        public int? DELSEV { get; set; }
        public int? HALL { get; set; }
        public int? HALLSEV { get; set; }
        public int? AGIT { get; set; }
        public int? AGITSEV { get; set; }
        public int? DEPD { get; set; }
        public int? DEPDSEV { get; set; }
        public int? ANX { get; set; }
        public int? ANXSEV { get; set; }
        public int? ELAT { get; set; }
        public int? ELATSEV { get; set; }
        public int? APA { get; set; }
        public int? APASEV { get; set; }
        public int? DISN { get; set; }
        public int? DISNSEV { get; set; }
        public int? IRR { get; set; }
        public int? IRRSEV { get; set; }
        public int? MOT { get; set; }
        public int? MOTSEV { get; set; }
        public int? NITE { get; set; }
        public int? NITESEV { get; set; }
        public int? APP { get; set; }
        public int? APPSEV { get; set; }

    }
}

