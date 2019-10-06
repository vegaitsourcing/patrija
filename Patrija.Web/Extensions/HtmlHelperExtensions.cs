using System;
using System.Web;
using System.Web.Mvc;

namespace Patrija.Web.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString MultiLineText(this HtmlHelper htmlHelper, string multilineText)
            => htmlHelper.Raw(multilineText.Replace("\n", "<br />"));
    }
}