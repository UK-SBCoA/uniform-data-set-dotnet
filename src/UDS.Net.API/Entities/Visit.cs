using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UDS.Net.API.Entities
{
    [Table("tbl_Visits")]
    [Index(nameof(ParticipationId), nameof(Number), IsUnique = true)]
    public class Visit : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("VisitId")]
        public int Id { get; set; }

        public int ParticipationId { get; set; }

        [ForeignKey("ParticipationId")]
        public virtual Participation Participation { get; set; } = default!;

        public int Number { get; set; }

        [MaxLength(3)]
        public string Kind { get; set; } = ""; // IVP, FVP, TIP, TFP

        [MaxLength(10)]
        public string Version { get; set; } = ""; // 3.0.0

        public DateTime StartDateTime { get; set; }

        public virtual List<FormStatus> FormStatuses { get; set; } = default!;

        public virtual A1 A1 { get; set; } = default!; // A1 required for all visit kinds

        public virtual A2 A2 { get; set; } = default!;

        public virtual A3 A3 { get; set; } = default!;

        public virtual IEnumerable<A4D> A4Ds { get; set; } = new List<A4D>();

        public virtual A4G A4G { get; set; } = default!;

        public virtual A5 A5 { get; set; } = default!;

        public virtual B1 B1 { get; set; } = default!;

        public virtual B4 B4 { get; set; } = default!;

        public virtual B5 B5 { get; set; } = default!;

        public virtual B6 B6 { get; set; } = default!;

        public virtual B7 B7 { get; set; } = default!;

        public virtual B8 B8 { get; set; } = default!;

        public virtual B9 B9 { get; set; } = default!;

        public virtual C1 C1 { get; set; } = default!;

        public virtual C2 C2 { get; set; } = default!;

        public virtual D1 D1 { get; set; } = default!;

        public virtual D2 D2 { get; set; } = default!;

        public virtual T1? T1 { get; set; } // T1 only required for TIP, TFP visits
    }
}

