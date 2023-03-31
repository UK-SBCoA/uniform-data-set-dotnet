using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Milestones
    /// Data template: https://files.alz.washington.edu/documentation/uds3-milestone-template.pdf
    /// </summary>
    [Table("tbl_M1s")]
    public class M1 : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FormId { get; set; }

        public int ParticipationId { get; set; }

        public virtual Participation Participation { get; set; } = default!;

        [MaxLength(20)]
        public string Status { get; set; } = default!;

        public int? CHANGEMO { get; set; }
        public int? CHANGEDY { get; set; }
        public int? CHANGEYR { get; set; }
        public int? PROTOCOL { get; set; }
        public int? ACONSENT { get; set; }
        public int? RECOGIM { get; set; }
        public int? REPHYILL { get; set; }
        public int? REREFUSE { get; set; }
        public int? RENAVAIL { get; set; }
        public int? RENURSE { get; set; }
        public int? NURSEMO { get; set; }
        public int? NURSEDY { get; set; }
        public int? NURSEYR { get; set; }
        public int? REJOIN { get; set; }
        public int? FTLDDISC { get; set; }
        public int? FTLDREAS { get; set; }
        [MaxLength(60)]
        public string? FTLDREAX { get; set; }
        public int? DECEASED { get; set; }
        public int? DISCONT { get; set; }
        public int? DEATHMO { get; set; }
        public int? DEATHDY { get; set; }
        public int? DEATHYR { get; set; }
        public int? AUTOPSY { get; set; }
        public int? DISCMO { get; set; }
        public int? DISCDAY { get; set; }
        public int? DISCYR { get; set; }
        public int? DROPREAS { get; set; }

    }
}
