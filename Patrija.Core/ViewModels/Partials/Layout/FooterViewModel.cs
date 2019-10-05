using System;
using System.Linq;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using Umbraco.Web;

namespace Patrija.Core.ViewModels.Partials.Layout
{
	public class FooterViewModel
	{
		public FooterViewModel(IFooter footer)
		{
			if (footer == null) throw new ArgumentNullException(nameof(footer));

			CopyrightText = footer.CopyrightText;
		    LogoText = footer.FooterLogoText;
            Logo = new ImageViewModel(footer.FooterLogo as Image);
		    Links = footer.FooterLinks.Select(fl => new LinkViewModel(fl)).ToArray();
		}

		public string CopyrightText { get; }
	    public string LogoText { get; }
        public ImageViewModel Logo { get; }
        public LinkViewModel[] Links { get; }
    }
}
