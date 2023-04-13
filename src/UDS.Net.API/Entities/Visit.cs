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

        public virtual IEnumerable<A4D> A4Ds { get; set; } = new List<A4D>();

        public virtual T1? T1 { get; set; } // T1 only required for TIP, TFP visits
    }
}

