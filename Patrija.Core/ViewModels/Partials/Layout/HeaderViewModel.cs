using System;
using Umbraco.Web;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using System.Linq;
using Patrija.Core.Contexts;

namespace Patrija.Core.ViewModels.Partials.Layout
{
	public class HeaderViewModel
	{
		public HeaderViewModel(IPageContext<IPage> context)
		{
			if (context == null) throw new ArgumentNullException(nameof(context));
            var header = context.Home as IHeader;

			Logo = new ImageViewModel(header.Logo as Image);
			LogoUrl = header.AncestorOrSelf<Patrija.Models.Generated.Home>().Url;
		    JoinUsLink = new LinkViewModel(header.AncestorOrSelf<Patrija.Models.Generated.Home>().JoinUsLink);

            var applicationPages = header.Children.OfType<IPage>().ToArray();
            var currentPageUrl = context.CurrentPage.Url;
            
            MenuItems = applicationPages.Prepend(header as IPage).Select(page => new LinkViewModel(page.Url, page.Name, IsLinkActive(page, currentPageUrl))).ToArray();
            
		}

        private bool IsLinkActive(IPage page, string currentPageUrl)
            => page.Url == currentPageUrl;

        public ImageViewModel Logo { get; }
	    public LinkViewModel JoinUsLink { get; }
	    public string LogoUrl { get; }
        public LinkViewModel[] MenuItems { get; }
    }
}
