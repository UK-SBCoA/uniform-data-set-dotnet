using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Called "participation" rather than "participant" because we are not storing any identifiable information
    /// </summary>
    [Table("Participation")]
    public class Participation : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ParticipationId")]
        public int Id { get; set; }

        /// <summary>
        /// There might need to be the ability to store a legacy identifier specific to your institution
        /// </summary>
        public string LegacyId { get; set; } = default!;

        public virtual IEnumerable<Visit> Visits { get; set; } = default!;
    }
}

