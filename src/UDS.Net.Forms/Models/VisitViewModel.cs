using System;
namespace UDS.Net.Forms.Models
{
    public class VisitViewModel
    {
        public int Id { get; set; }

        public int ParticipationId { get; set; }

        public int Number { get; set; }

        public string Kind { get; set; } = "";

        public string Version { get; set; } = "";

        public DateTime StartDateTime { get; set; }

        public IList<FormViewModel> Forms { get; set; } = new List<FormViewModel>();
    }
}

