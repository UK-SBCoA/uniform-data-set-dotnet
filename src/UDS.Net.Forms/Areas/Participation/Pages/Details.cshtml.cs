using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UDS.Net.Services;

namespace UDS.Net.Forms.Areas.Participation.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IParticipationService _participationService;

        public DetailsModel(IParticipationService participationService)
        {
            _participationService = participationService;
        }

        public IActionResult OnGet(int? id)
        {
            return Page();
        }
    }
}
