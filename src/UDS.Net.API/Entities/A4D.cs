using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    [Table("tbl_A4Ds")]
    public class A4D : Form
	{
		[MaxLength(6)]
		public string DRUGID { get; set; } = "";
	}
}

