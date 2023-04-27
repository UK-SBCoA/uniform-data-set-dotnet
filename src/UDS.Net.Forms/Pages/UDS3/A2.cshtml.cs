﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UDS.Net.Forms.Extensions;
using UDS.Net.Forms.Models;
using UDS.Net.Forms.Models.PageModels;
using UDS.Net.Forms.Models.UDS3;
using UDS.Net.Services;

namespace UDS.Net.Forms.Pages.UDS3
{
    public class A2Model : FormPageModel
    {
        [BindProperty]
        public A2 A2 { get; set; } = default!;

        public A2Model(IVisitService visitService) : base(visitService, "A2")
        {
        }


        public async Task<IActionResult> OnGet(int? id)
        {
            await base.OnGet(id);

            if (_formModel != null)
            {
                A2 = (A2)_formModel; // class library should always handle new instances
            }

            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            // if model is attempting to be completed, validation against domain form rules and visit rules
            // if not validates, return with errors

            if (ModelState.IsValid)
            {
                await base.OnPost(id); // checks for domain-level business rules validation
            }

            ModelState.AddModelError("A2.INSEX", "error message test");

            var visit = await _visitService.GetByIdWithForm("", id, _formKind);

            if (visit == null)
                return NotFound();

            Visit = visit.ToVM();

            return Page();
        }
    }
}
