using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    [Table("tbl_T1s")]
    public class T1 : Form
    {
        public int? TELCOG { get; set; }
        public int? TELILL { get; set; }
        public int? TELHOME { get; set; }
        public int? TELREFU { get; set; }
        public int? TELCOV { get; set; }
        public int? TELOTHR { get; set; }
        public string? TELOTHRX { get; set; }
        public int? TELMOD { get; set; }
        public int? TELINPER { get; set; }
        public int? TELMILE { get; set; }

    }
}

