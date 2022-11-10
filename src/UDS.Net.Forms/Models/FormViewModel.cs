using System;
namespace UDS.Net.Forms.Models
{
    public class FormViewModel
    {
        public int VisitId { get; set; }

        public string Version { get; set; } = "";

        public string Title { get; set; } = "";

        public string Status { get; set; } = "";

        public bool IsRequiredForVisitKind { get; set; }

        public bool IncludeInPacketSubmission { get; set; }
    }
}

