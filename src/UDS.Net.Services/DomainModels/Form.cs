using System;
namespace UDS.Net.Services.DomainModels
{
    public class Form
    {
        public int VisitId { get; set; } // also the form id

        public string Version { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Kind { get; set; }

        public Visit Visit { get; set; }

        public IFormFields Fields { get; set; }

        public Form(Visit visit, string title, IFormFields fields)
        {
            Title = title;
            VisitId = visit.Id;
            Visit = visit;
            Kind = visit.Kind;
            Fields = fields;
            Description = fields.GetDescription();
        }
    }
}

