using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    public class Visit : BaseEntity
    {
        public int ParticipationId { get; set; }

        [ForeignKey("ParticipationId")]
        public virtual Participation Participation { get; set; }


    }
}

