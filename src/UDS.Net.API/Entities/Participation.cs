using System;
using System.ComponentModel.DataAnnotations;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Called "participation" rather than "participant" because we are not storing any identifiable information
    /// </summary>
    public class Participation : BaseEntity
    {
        /// <summary>
        /// There might need to be the ability to store a legacy identifier specific to your institution
        /// </summary>
        public string LegacyId { get; set; }

        public virtual IEnumerable<Visit> Visits { get; set; }
    }
}

