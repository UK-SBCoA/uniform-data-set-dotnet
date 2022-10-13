using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;using UDS.Net.Services;
using UDS.Net.Web.MVC;

namespace UDS.Net.Web.MVC.Controllers
{
    public class VisitsController: Controller
    {
        private readonly IVisitService _visitService;
        public VisitsController(IVisitService visitService) {
            _visitService = visitService;
        }
        public async Task<IActionResult> Index() {
            var visits = await _visitService.List(User.Identity.Name);
            return View(visits);
        }
    }
}