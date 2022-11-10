using System;
using System.Collections.Generic;
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

        public Participation Participation { get; set; } = new Participation();

        public IList<Form> Forms { get; set; } = new List<Form>();

        public Visit(string version, string kind)
        {
            Version = version;
            Kind = kind;

            if (!String.IsNullOrWhiteSpace(version) && !String.IsNullOrWhiteSpace(kind))
            {
                // Configure forms based on UDS version and visit kind
                if (version == "UDS3")
                {
                    if (kind == "IVP")
                    {
                        Forms.Add(new Form(this, "A1", new UDS3_A1_IVP()));
                    }
                    else if (kind == "FVP")
                    {

                    }
                    else if (kind == "TIP")
                    {

                    }
                    else if (kind == "TFP")
                    {

                    }
                }
            }
        }
    }
}

