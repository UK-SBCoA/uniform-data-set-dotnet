﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UDS.Net.Forms.Areas.Participation.Pages
{
    public class DetailsModel : PageModel
    {
        public IActionResult OnGet(int? id)
        {
            return Page();
        }
    }
}
