using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// NACC Functional Assessment Scale (FAS)
    /// </summary>
    [Table("tbl_B7s")]
    public class B7 : Form
	{
        public int? BILLS { get; set; }
        public int? TAXES { get; set; }
        public int? SHOPPING { get; set; }
        public int? GAMES { get; set; }
        public int? STOVE { get; set; }
        public int? MEALPREP { get; set; }
        public int? EVENTS { get; set; }
        public int? PAYATTN { get; set; }
        public int? REMDATES { get; set; }
        public int? TRAVEL { get; set; }
    }
}

