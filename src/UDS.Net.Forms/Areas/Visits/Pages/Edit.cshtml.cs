using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UDS.Net.Forms.Models;
using UDS.Net.Services;

namespace UDS.Net.Forms.Areas.Visits.Pages
{
    public class EditModel : VisitPageModel
    {
        public EditModel(IVisitService visitService) : base(visitService)
        {
        }

    }
}
