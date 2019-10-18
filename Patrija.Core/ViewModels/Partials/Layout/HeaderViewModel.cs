using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using System;
using System.Linq;

namespace Patrija.Core.ViewModels.Partials.Layout
{
    public class HeaderViewModel
    {
        public HeaderViewModel(IPageContext<IPage> context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            var header = context.Home as IHeader;

            Logo = header.Logo != null ? new ImageViewModel(header.Logo as Image) : default(ImageViewModel);
            LogoUrl = context.Home.Url;
            JoinUsLink = header.JoinUsLink != null ? new LinkViewModel(header.JoinUsLink) : default(LinkViewModel);

            var applicationPages = context.Home.Children.OfType<IPage>().ToArray();
            var currentPageUrl = context.CurrentPage.Url;

            MenuItems = applicationPages.Prepend(header as IPage).Where(page => !page.UmbracoNaviHide).Select(page => new LinkViewModel(page.Url, page.Name, IsLinkActive(page, currentPageUrl))).ToArray();

        }

        private bool IsLinkActive(IPage page, string currentPageUrl)
            => string.Equals(currentPageUrl, page.Url, StringComparison.OrdinalIgnoreCase);

        public ImageViewModel Logo { get; }
        public LinkViewModel JoinUsLink { get; }
        public string LogoUrl { get; }
        public LinkViewModel[] MenuItems { get; }
    }
}
