using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UDS.Net.Forms.Extensions;
using UDS.Net.Forms.Models;
using UDS.Net.Services;

namespace UDS.Net.Forms.Models.PageModels
{
    public class FormPageModel : PageModel
    {
        [BindProperty]
        public VisitModel? Visit { get; set; }

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

            var visit = await _visitService.GetByIdWithForm("", id.Value, "A1"); // TODO dynamic formId

            if (visit == null)
                return NotFound();

            var form = visit.Forms.Where(f => f.Kind.Contains("A1")).FirstOrDefault(); // TODO dynamic formId

            _formModel = form.ToVM(); // this will have the subclass
            Visit = visit.ToVM();

            return Page();
        }

    }
}

