﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UDS.Net.Forms.Extensions;
using UDS.Net.Forms.Models;
using UDS.Net.Forms.Pages.UDS3;
using UDS.Net.Services;

namespace UDS.Net.Forms.Models.PageModels
{
    public class FormPageModel : PageModel
    {
        [BindProperty]
        public VisitModel Visit { get; set; } = default!;

        protected readonly IVisitService _visitService;
        protected string _formKind { get; set; }
        protected FormModel _formModel;

        public FormPageModel(IVisitService visitService, string formKind) : base()
        {
            _visitService = visitService;
            _formKind = formKind;
        }

        protected async Task<IActionResult> OnGet(int? id)
        {
            if (id == null || _formKind == null)
                return NotFound();

            var visit = await _visitService.GetByIdWithForm("", id.Value, _formKind);

            if (visit == null)
                return NotFound();

            Visit = visit.ToVM();

            if (Visit != null)
                ViewData["Title"] = $"Participant {Visit.ParticipationId} Visit {Visit.Number} {Visit.Kind}";

            var form = visit.Forms.Where(f => f.Kind.Contains(_formKind)).FirstOrDefault();

            _formModel = form.ToVM(); // this will have the subclass

            return Page();
        }

        [ValidateAntiForgeryToken]
        protected async Task<IActionResult> OnPost(int id)
        {
            var visit = Visit.ToEntity();

            visit.TryValidate(_formKind);

            if (visit.IsValid())
            {
                if (id == 0)
                {
                    // TODO Add
                }
                else
                {
                    // TODO Update
                    await _visitService.Update("", visit);
                }
            }
            else
            {
                // update model state with errors
                var errors = visit.GetModelErrors();
                foreach (var error in errors)
                {
                    ModelState.AddModelError(error.Key, error.Value); // TODO each key must be the same as what is used in the model
                }
            }

            return Page();
        }

    }
}

