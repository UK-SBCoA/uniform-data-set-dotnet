using System;
using System.Text.Json.Serialization;

namespace UDS.Net.Dto
{
    [JsonDerivedType(typeof(FormDto), "FormDto")]
    [JsonDerivedType(typeof(A1Dto), "A1Dto")]
    [JsonDerivedType(typeof(A2Dto), "A2Dto")]
    public class FormDto : BaseDto
    {
        public int VisitId { get; set; }

        public string Kind { get; set; }

        public string Status { get; set; }

        public string Language { get; set; }

        public bool? IsIncluded { get; set; }

        public string ReasonCode { get; set; }
    }
}

