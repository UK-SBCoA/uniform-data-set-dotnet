using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UDS.Net.Forms.Extensions;
using UDS.Net.Forms.Models;
using UDS.Net.Services;

namespace UDS.Net.Forms.Areas.Visit.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IVisitService _visitService;

        [BindProperty]
        public VisitViewModel? Visit { get; set; }

        public CreateModel(IVisitService visitService)
        {
            _visitService = visitService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Visit != null) await _visitService.Add("", Visit.ToEntity());

            return RedirectToPage("./Index");
        }
    }
}
