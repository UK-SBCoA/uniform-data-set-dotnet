
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UDS.Net.API.Entities
{
	[Owned]
	public class A3FamilyMember
	{
		public int? MOB { get; set; }

		public int? YOB { get; set; }

		public int? AGD { get; set; }

		public int? NEU { get; set; }

		public int? PDX { get; set; }

		public int? MOE { get; set; }

		public int? AGO { get; set; }
	}
}

