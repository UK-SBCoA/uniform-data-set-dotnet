using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace UDS.Net.Forms.TagHelpers
{
    public class RadioListItem : SelectListItem
    {
        public string IfSelectedEnables { get; set; }

        public RadioListItem(string text, string value) : base(text, value)
        {
        }

        public RadioListItem(string text, string value, string ifSelectedEnables) : base(text, value)
        {
            IfSelectedEnables = ifSelectedEnables;
        }
    }
}

