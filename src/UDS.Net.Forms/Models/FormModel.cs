using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UDS.Net.Forms.Models
{
    public class FormModel
    {
        public int Id { get; set; }

        public int VisitId { get; set; }

        public string Kind { get; set; } = "";

        public string Version { get; set; } = "";

        public string Title { get; set; } = "";

        public string Description { get; set; } = "";

        public string Status { get; set; } = "";

        public bool IsRequiredForVisitKind { get; set; }

        public string Language { get; set; } = "";

        public bool IncludeInPacketSubmission { get; set; }

        public int? ReasonCodeNotIncluded { get; set; }

        public string ReasonNotIncluded { get; set; } = "";


        public bool IsValid()
        {
            return true;
        }

        public void Validate()
        {
        }

    }
}

