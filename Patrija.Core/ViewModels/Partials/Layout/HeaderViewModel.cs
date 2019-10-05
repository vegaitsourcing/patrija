using System;
using Umbraco.Web;
using Patrija.Core.Extensions;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using System.Linq;

namespace Patrija.Core.ViewModels.Partials.Layout
{
	public class HeaderViewModel
	{
		public HeaderViewModel(IHeader header)
		{
			if (header == null) throw new ArgumentNullException(nameof(header));

			//Logo = header.Logo.ToViewModel();
			LogoUrl = header.AncestorOrSelf<Patrija.Models.Generated.Home>().Url;
		    JoinUsLink = new LinkViewModel(header.AncestorOrSelf<Patrija.Models.Generated.Home>().JoinUsLink);

		}

		public ImageViewModel Logo { get; }
		public string LogoUrl { get; }
	    public LinkViewModel JoinUsLink { get; }

    }
}
