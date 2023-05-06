using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// IVP data template https://files.alz.washington.edu/documentation/uds3-ivp-template.pdf
    /// FVP data template https://files.alz.washington.edu/documentation/uds3-fvp-template.pdf
    /// Form A2: Co-participant demographics
    /// </summary>
    [Table("tbl_A2s")]
    public class A2 : Form
    {
        public int? INBIRMO { get; set; }
        public int? INBIRYR { get; set; }
        public int? INSEX { get; set; }
        public int? NEWINF { get; set; }
        public int? INHISP { get; set; }
        public int? INHISPOR { get; set; }
        [MaxLength(60)]
        public string? INHISPOX { get; set; }
        public int? INRACE { get; set; }
        [MaxLength(60)]
        public string? INRACEX { get; set; }
        public int? INRASEC { get; set; }
        [MaxLength(60)]
        public string? INRASECX { get; set; }
        public int? INRATER { get; set; }
        [MaxLength(60)]
        public string? INRATERX { get; set; }
        public int? INEDUC { get; set; }
        public int? INRELTO { get; set; }
        public int? INKNOWN { get; set; }
        public int? INLIVWTH { get; set; }
        public int? INVISITS { get; set; }
        public int? INCALLS { get; set; }
        public int? INRELY { get; set; }

    }
}

