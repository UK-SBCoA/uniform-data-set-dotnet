using System;

namespace UDS.Net.Dto
{
    public class BaseDto
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CreatedBy { get; set; }

        public string? ModifiedBy { get; set; }

        public string? DeletedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}

