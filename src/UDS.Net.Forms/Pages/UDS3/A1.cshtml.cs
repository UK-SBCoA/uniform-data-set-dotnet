using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UDS.Net.Forms.Extensions;
using UDS.Net.Forms.Models.PageModels;
using UDS.Net.Forms.Models.UDS3;
using UDS.Net.Services;

namespace UDS.Net.Forms.Pages.UDS3
{
    public class A1Model : FormPageModel
    {
        [BindProperty]
        public A1 A1 { get; set; } = default!;

        public A1Model(IVisitService visitService) : base(visitService)
        {
        }

        public async Task<IActionResult> OnGet(int? id)
        {
            await base.OnGet(id);

            if (Visit != null)
            {
                if (_formModel != null)
                {
                    if (Visit.Kind == "IVP")
                    {
                        A1 = (A1)_formModel;
                    }
                    else if (Visit.Kind == "FVP")
                    {
                    }
                    else if (Visit.Kind == "TIP")
                    {
                    }
                    else if (Visit.Kind == "TFP")
                    {
                    }
                }
                else
                {
                    A1 = new A1()
                    {
                        VisitId = Visit.Id,
                        Title = "A1",
                        Status = "NotStarted"
                    };
                }
            }

            //if (id == null)
            //    return NotFound();

            //var visit = await _visitService.GetByIdWithForm("", id.Value, "A1"); // TODO dynamic formId

            //if (visit == null)
            //    return NotFound();

            //Visit = visit.ToVM();


            // Determine visit kind
            // Determine if visit already has form type for visit kind

            // If yes, edit (if visit not completed) or display (if visit completed)
            // If no, create



            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            // if model is attempting to be completed, validation against domain form rules and visit rules
            // if not validates, return with errors

            var boundProperty = A1;

            return Page();
        }
    }
}
