using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UDS.Net.API.Entities
{
	/// <summary>
	/// IVP data template https://files.alz.washington.edu/documentation/uds3-ivp-template.pdf
	/// FVP data template https://files.alz.washington.edu/documentation/uds3-fvp-template.pdf
	/// Form A1: Participant Demographics, page 3
	/// </summary>
	[Table("tbl_A1s")]
	public class A1 : Form
    {
        public int? REASON { get; set; }
		public int? REFERSC { get; set; }
		public int? LEARNED { get; set; }
		public int? PRESTAT { get; set; }
		public int? PRESPART { get; set; }
		public int? SOURCENW { get; set; }
		public int? BIRTHMO { get; set; }
		public int? BIRTHYR { get; set; }
		public int? SEX { get; set; }
		public int? HISPANIC { get; set; }
		public int? HISPOR { get; set; }
		[MaxLength(60)]
		public string? HISPORX { get; set; }
		public int? RACE { get; set; }
		[MaxLength(60)]
		public string? RACEX { get; set; }
		public int? RACESEC { get; set; }
		[MaxLength(60)]
		public string? RACESECX { get; set; }
		public int? RACETER { get; set; }
		[MaxLength(60)]
		public string? RACETERX { get; set; }
		public int? PRIMLANG { get; set; }
		[MaxLength(60)]
		public string? PRIMLANX { get; set; }
		public int? EDUC { get; set; }
		public int? MARISTAT { get; set; }
		public int? LIVSITUA { get; set; }
		public int? INDEPEND { get; set; }
		public int? RESIDENC { get; set; }
		[MaxLength(3)]
		public string? ZIP { get; set; } = default!;
		public int? HANDED { get; set; }
    }
}
