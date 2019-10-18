using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using System;
using System.Linq;

namespace Patrija.Core.ViewModels.Partials.Layout
{
    public class FooterViewModel
	{
		public FooterViewModel(IFooter model)
		{
			if (model == null) throw new ArgumentNullException(nameof(model));

			CopyrightText = model.CopyrightText;
		    LogoText = model.FooterLogoText;
            Logo = model.FooterLogo != null ? new ImageViewModel(model.FooterLogo as Image) : default(ImageViewModel);
		    Links = model.FooterLinks.Select(fl => new LinkViewModel(fl)).ToArray();
		}

		public string CopyrightText { get; }
	    public string LogoText { get; }
        public ImageViewModel Logo { get; }
        public LinkViewModel[] Links { get; }
    }
}
