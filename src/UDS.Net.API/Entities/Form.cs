using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    public abstract class Form : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("FormId")]
        public int Id { get; set; }

        public int VisitId { get; set; }

        public virtual Visit Visit { get; set; } = default!;

        [MaxLength(20)]
        public string Status { get; set; } = default!;

        [Column("LANG")]
        public Language? Language { get; set; }

        [Column("SUB")]
        public bool? IsIncluded { get; set; }

        [Column("NOT")]
        public ReasonCode? ReasonCode { get; set; }
    }
}

