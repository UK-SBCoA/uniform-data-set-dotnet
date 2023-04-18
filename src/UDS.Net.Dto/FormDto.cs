using System;
using System.Text.Json.Serialization;

namespace UDS.Net.Dto
{
    [JsonDerivedType(typeof(FormDto), "FormDto")]
    [JsonDerivedType(typeof(A1Dto), "A1Dto")]
    [JsonDerivedType(typeof(A2Dto), "A2Dto")]
    [JsonDerivedType(typeof(A3Dto), "A3Dto")]
    [JsonDerivedType(typeof(A4DDto), "A4DDto")]
    [JsonDerivedType(typeof(A4GDto), "A4GDto")]
    [JsonDerivedType(typeof(A5Dto), "A5Dto")]
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

