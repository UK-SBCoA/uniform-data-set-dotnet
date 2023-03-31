using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Geriatric Depression Scale (GDS)
    /// </summary>
    [Table("tbl_B6s")]
    public class B6 : Form
	{
        public int? NOGDS { get; set; }
        public int? SATIS { get; set; }
        public int? DROPACT { get; set; }
        public int? EMPTY { get; set; }
        public int? BORED { get; set; }
        public int? SPIRITS { get; set; }
        public int? AFRAID { get; set; }
        public int? HAPPY { get; set; }
        public int? HELPLESS { get; set; }
        public int? STAYHOME { get; set; }
        public int? MEMPROB { get; set; }
        public int? WONDRFUL { get; set; }
        public int? WRTHLESS { get; set; }
        public int? ENERGY { get; set; }
        public int? HOPELESS { get; set; }
        public int? BETTER { get; set; }
        public int? GDS { get; set; }
    }
}

