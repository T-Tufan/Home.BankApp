using Home.BankApp.Web.Data.Context;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.BankApp.Web.TagHelpers
{
    [HtmlTargetElement("getAccountCount")]
    public class GetAccountCount : TagHelper
    {
        public int AppUserId { get; set; }

        private readonly BankContext _context;
        public GetAccountCount(BankContext context)
        {
            _context = context;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var accountCount = _context.Accounts.Count(x => x.ApplicationUserId == AppUserId);
            var html = $"<span class = 'badge bg-danger'>{accountCount}</span>";
            output.Content.SetHtmlContent(html);
            base.Process(context, output);
        }
    }
}
