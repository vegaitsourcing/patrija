using Patrija.Models.Generated;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Patrija.Core.ViewModels.Partials.Share
{
    public class ShareViewModel
    {
        public ShareViewModel(IPage model)
        {
            CurrentPage = model;
        }
        public IPage CurrentPage { get; set; }


        public string Populate(string socialUrl, IPage model)
        {
            string hashtags = model.SeoKeywords;
            string title = model.PageTitle;
            string url = model.Url(mode: UrlMode.Absolute);

            socialUrl = socialUrl.Replace("$hashtags", hashtags);
            socialUrl = socialUrl.Replace("$title", title);
            socialUrl = socialUrl.Replace("$url", url);

            return socialUrl;
        }
    }
}