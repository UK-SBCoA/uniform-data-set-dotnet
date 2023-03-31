using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Physical
    /// </summary>
    [Table("tbl_B1s")]
    public class B1 : Form
    {
        public int? HEIGHT { get; set; }
        public int? WEIGHT { get; set; }
        public int? BPSYS { get; set; }
        public int? BPDIAS { get; set; }
        public int? HRATE { get; set; }
        public int? VISION { get; set; }
        public int? VISCORR { get; set; }
        public int? VISWCORR { get; set; }
        public int? HEARING { get; set; }
        public int? HEARAID { get; set; }
        public int? HEARWAID { get; set; }

    }
}

