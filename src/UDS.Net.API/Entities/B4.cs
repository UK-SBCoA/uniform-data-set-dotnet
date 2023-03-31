using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// CDR Dementia Staging Instrument Plus NACC FTLD Behavior & Language Domains (CDR Plus NACC FTLD)
    /// </summary>
    [Table("tbl_B4s")]
    public class B4 : Form
    {
        public int? ORIENT { get; set; }
        public int? JUDGMENT { get; set; }
        public int? COMMUN { get; set; }
        public int? HOMEHOBB { get; set; }
        public int? PERSCARE { get; set; }
        public int? CDRSUM { get; set; }
        public int? CDRGLOB { get; set; }
        public int? COMPORT { get; set; }
        public int? CDRLANG { get; set; }
    }
}

