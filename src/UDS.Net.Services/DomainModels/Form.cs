using System;
namespace UDS.Net.Services.DomainModels
{
    public class Form
    {
        public int VisitId { get; set; }

        public int Id { get; set; }

        public string Version { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Kind { get; set; }

        public string Status { get; set; }

        public string Language { get; set; }

        public bool? IsIncluded { get; set; }

        public string ReasonCode { get; set; }

        public Visit Visit { get; set; }

        public IFormFields Fields { get; set; }

        public Form(Visit visit, string kind)
        {
            // TODO This is used in VisitService to initialize a new form when one doesn't exist, but should
            VisitId = visit.Id;
            Visit = visit;
            Kind = kind;
            Status = "NotStarted";
        }

        public Form(Visit visit, int id, string title, string kind, string status, string language, bool? isIncluded, string reasonCode, IFormFields fields)
        {
            Id = id;
            Title = title;
            VisitId = visit.Id;
            Visit = visit;
            Kind = kind;
            Status = status;
            Language = language;
            IsIncluded = isIncluded;
            ReasonCode = reasonCode;

            Fields = fields;
            Version = fields.GetVersion();
            Description = fields.GetDescription();
        }

    }
}

