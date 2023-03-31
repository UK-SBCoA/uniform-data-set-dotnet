using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    [Table("tbl_A4Gs")]
    public class A4G : Form
	{
		public int? ANYMEDS { get; set; }
	}
}

