using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UDS.Net.Forms.Models;

namespace UDS.Net.Forms.Areas.Participation.Pages
{
    /// <summary>
    /// TODO Continue tutorial here https://learn.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-7.0&tabs=visual-studio-mac
    ///
    /// The PageModel class allows separation of the logic of a page from its presentation. It defines page handlers for requests sent to the page and the data used to render the page.
    /// </summary>
    public class CreateModel : PageModel
    {
        [BindProperty]
        public ParticipationViewModel? Participation { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            return RedirectToPage("./Details");
        }
    }
}
