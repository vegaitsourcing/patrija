using Patrija.Core.Controllers.Surface.Partials;
using System.Web.Mvc;

namespace Patrija.Core.Extensions
{
    public static class UrlHelperExtensions
    {
        public static string GetBlogsArticlesListingUrl(this UrlHelper helper)
        {
            return helper?.Action(nameof(ListingController.BlogsArticlesListing), nameof(ListingController).RemoveControllerSuffix()) ?? string.Empty;
        }
       
    }
}
