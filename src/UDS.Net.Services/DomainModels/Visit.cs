﻿using System;
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

                        Forms.Add(new Form(Id, existing.Id, existing.Title, existing.Kind, existing.Status, existing.Language, existing.IsIncluded, existing.ReasonCode, existing.Fields));
                    }
                    else
                    {
                        Forms.Add(new Form(Id, formKind));
                    }
                }

            }
        }

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
            // TODO validate child form as well
            GetModelErrors();
            return true;
        }

        public bool IsValid()
        {
            // TODO look up ModelState and review how validity is determined
            return true;
        }

        public Dictionary<string, string> GetModelErrors()
        {
            return new Dictionary<string, string>();
        }
    }
}

