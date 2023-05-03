using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UDS.Net.Services.DomainModels.Forms;

namespace UDS.Net.Services.DomainModels
{
    /// <summary>
    /// Visit domain model
    /// </summary>
    public class Visit
    {
        public int Id { get; set; }

        public int ParticipationId { get; set; }

        public int Number { get; set; }

        public string Version { get; set; } = "";

        public string Kind { get; set; } = "";

        public DateTime StartDateTime { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public string DeletedBy { get; set; }

        public bool IsDeleted { get; set; }

        // Read more https://github.com/dotnet/aspnetcore/blob/6d30638626ff0f471f431ae2247ce95480e418ef/src/Mvc/Mvc.Abstractions/src/ModelBinding/ModelStateDictionary.cs#L616
        public bool IsValid
        {
            get
            {
                return GetValidity("", 0);
            }

        }

        public Participation Participation { get; set; } = new Participation();

        public IList<Form> Forms { get; set; } = new List<Form>();

        private void BuildFormsContract(string version, string kind, IList<Form> existingForms)
        {
            if (version == "UDS3")
            {
                Dictionary<string, string[]> UDS3 = new Dictionary<string, string[]>
                {
                    { "IVP", new string[] { "A1", "A2", "A3", "A4", "A5" } },
                    { "FVP", new string[] { "A1", "A2", "A3", "A4", "A5" } },
                    { "TIP", new string[] { "T1", "A1", "A2", "A3", "A4", "A5" } },
                    { "TVP" , new string[] { "T1", "A1", "A2", "A3", "A4", "A5" } }
                };

                Dictionary<string, string[]> UDS4 = new Dictionary<string, string[]>
                {
                    { "IVP", new string[] { "A1", "A2", "A3", "A4", "A5D2" } },
                    { "FVP", new string[] { "A1", "A2", "A3", "A4", "A5D2" } },
                    { "TIP", new string[] { "T1", "A1", "A2", "A3", "A4", "A5" } },
                    { "TVP" , new string[] { "T1", "A1", "A2", "A3", "A4", "A5" } }
                };

                var formDefinitions = UDS3.Where(u => u.Key == kind).FirstOrDefault();

                foreach (var formKind in formDefinitions.Value)
                {
                    bool hasExisting = existingForms.Where(f => f.Kind == formKind).Any();

                    if (hasExisting)
                    {
                        var existing = existingForms.Where(f => f.Kind == formKind).FirstOrDefault();

                        Forms.Add(new Form(Id, existing.Id, existing.Title, existing.Kind, existing.Status, existing.Language, existing.IsIncluded, existing.ReasonCode, existing.CreatedAt, existing.CreatedBy, existing.ModifiedBy, existing.DeletedBy, existing.IsDeleted, existing.Fields));
                    }
                    else
                    {
                        Forms.Add(new Form(Id, formKind, CreatedBy));
                    }
                }

            }
        }

        private bool GetValidity(string node, int currentDepth)
        {
            // TODO check each property if it has been validated or if it's unvalidated
            // then if unvalidated, check if it is invalid
            return true;
        }

        public int ErrorCount { get; private set; }

        public int Count { get; private set; }

        public Visit(int id, int number, int participationId, string version, string kind, DateTime startDateTime, DateTime createdAt, string createdBy, string modifiedBy, string deletedBy, bool isDeleted, IList<Form> existingForms)
        {
            Id = id;
            Number = number;
            ParticipationId = participationId;
            Version = version;
            Kind = kind;
            StartDateTime = startDateTime;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            ModifiedBy = modifiedBy;
            DeletedBy = deletedBy;
            IsDeleted = IsDeleted;

            BuildFormsContract(Version, Kind, existingForms);

        }

        // TODO There's form fields and then there's validation rules for the form fields based on visit type
        // look up generics builder
        // https://stackoverflow.com/questions/30895888/setting-common-base-class-properties-when-creating-objects
        // TODO Use notifications pattern to return errors and not throwing exceptions

        public bool TryValidate(string formKind)
        {
            // TODO validate the visit against any rules that might have changed due to form fields changing
            GetModelErrors();
            return true;
        }

        public IEnumerable<VisitValidationResult> GetModelErrors()
        {
            yield break;
        }
    }
}

