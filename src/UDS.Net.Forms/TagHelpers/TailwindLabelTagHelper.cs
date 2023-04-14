using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace UDS.Net.Forms.TagHelpers
{
    [HtmlTargetElement("label", Attributes = "asp-for")]
    public class TailwindLabelTagHelper : TagHelper
    {
        private const string css = "block text-sm font-medium text-gray-700";
        // block text-sm font-medium leading-6 text-gray-900
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            output.Attributes.Add("class", css);
        }
    }
}

