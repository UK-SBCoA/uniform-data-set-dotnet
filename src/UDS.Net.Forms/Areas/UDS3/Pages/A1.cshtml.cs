using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UDS.Net.Forms.Models.UDS3;
using UDS.Net.Services;

namespace UDS.Net.Forms.Areas.UDS3.Pages
{
    public class A1Model : PageModel
    {
        [BindProperty]
        public A1_IVP A1 { get; set; } = default!;

        public A1Model()
        {
        }

        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
                return NotFound();

            // TODO get visit by id
            // Determine visit kind
            // Determine if visit already has form type for visit kind

            // If yes, edit (if visit not completed) or display (if visit completed)
            // If no, create

            A1 = new A1_IVP();

            return Page();
        }
    }
}
