using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UDS.Net.Forms.Extensions;
using UDS.Net.Forms.Models;
using UDS.Net.Forms.Pages.UDS3;
using UDS.Net.Services;

namespace UDS.Net.Forms.Models.PageModels
{
    public class FormPageModel : PageModel
    {
        [BindProperty]
        public VisitModel Visit { get; set; } = default!;

        private const string KIND = "A1";
        protected FormModel _formModel;
        protected readonly IVisitService _visitService;

        public FormPageModel(IVisitService visitService) : base()
        {
            _visitService = visitService;
        }

        protected async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
                return NotFound();

            if (Visit != null)
                ViewData["Title"] = $"Participant {Visit.ParticipationId} Visit {Visit.Number} {Visit.Kind}";

            if (this is A1Model)
            {
                // Is there a way to get the form kind without hard-coding?
                var nameOf = nameof(A1Model);
                var another = this.GetType();
            }
            var visit = await _visitService.GetByIdWithForm("", id.Value, KIND);
            if (visit == null)
                return NotFound();

            var form = visit.Forms.Where(f => f.Kind.Contains(KIND)).FirstOrDefault();

            _formModel = form.ToVM(); // this will have the subclass
            Visit = visit.ToVM();

            return Page();
        }

        protected async Task<IActionResult> OnPost(int id)
        {
            var visit = Visit.ToEntity();

            visit.TryValidate(KIND);

            if (visit.IsValid())
            {
                if (id == 0)
                {
                    // TODO Add
                }
                else
                {
                    // TODO Update
                    await _visitService.Update("", visit);
                }
            }
            else
            {
                // update model state with errors
                var errors = visit.GetModelErrors();
                foreach (var error in errors)
                {
                    ModelState.AddModelError(error.Key, error.Value); // TODO each key must be the same as what is used in the model
                }
            }

            return Page();
        }

    }
}

