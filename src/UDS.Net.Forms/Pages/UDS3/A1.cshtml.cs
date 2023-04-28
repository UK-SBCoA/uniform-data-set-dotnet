using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UDS.Net.Forms.Extensions;
using UDS.Net.Forms.Models;
using UDS.Net.Forms.Models.PageModels;
using UDS.Net.Forms.Models.UDS3;
using UDS.Net.Services;

namespace UDS.Net.Forms.Pages.UDS3
{
    public class A1Model : FormPageModel
    {
        [BindProperty]
        public A1 A1 { get; set; } = default!;

        public A1Model(IVisitService visitService) : base(visitService, "A1")
        {
        }

        public async Task<IActionResult> OnGet(int? id)
        {
            await base.OnGet(id);

            if (_formModel != null)
            {
                A1 = (A1)_formModel; // class library should always handle new instances
            }

            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            /*
             * ValidationContext describes any member on which validation is performed. It also enables
             * custom validation to be added through any service that implements the IServiceProvider
             * interface.
             */
            foreach (var result in A1.Validate(new ValidationContext(A1, null, null)))
            {
                var memberName = result.MemberNames.FirstOrDefault();
                ModelState.AddModelError($"A1.{memberName}", result.ErrorMessage);
            }

            // if model is attempting to be completed, validation against domain form rules and visit rules
            // if not validates, return with errors

            if (ModelState.IsValid)
            {
                await base.OnPost(id); // checks for domain-level business rules validation
            }

            var visit = await _visitService.GetByIdWithForm("", id, _formKind);

            if (visit == null)
                return NotFound();

            Visit = visit.ToVM();

            return Page();
        }
    }
}
