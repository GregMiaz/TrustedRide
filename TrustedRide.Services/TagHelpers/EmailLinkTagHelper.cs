using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrustedRide.Services.TagHelpers
{
    public class EmailLinkTagHelper : TagHelper
    {
        public string Email { get; set; }
        public string Message { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", $"mailto:{Email}");

            output.Content.SetContent(Message);
        }
    }
}
