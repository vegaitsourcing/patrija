using System;
using System.Linq;
using Patrija.Core.Contexts;
using Patrija.Core.Extensions;
using Patrija.Core.ViewModels.Partials.Layout;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Pages
{
	public class PageViewModel
	{
		public PageViewModel(IPageContext<IPage> context)
		{
			if (context == null) throw new ArgumentNullException(nameof(context));

			MetaTagsLazy = new Lazy<MetaTagsViewModel>(() => new MetaTagsViewModel(context.CreateSeoContext(context.Page)));
			HeaderLazy = new Lazy<HeaderViewModel>(() => new HeaderViewModel(context));
			FooterLazy = new Lazy<FooterViewModel>(() => new FooterViewModel(context.Home));
			GoogleTagManagerScriptCodeLazy = new Lazy<string>(() => context.Home.GoogleTagManagerScriptCode);
			GoogleTagManagerNonScriptCodeLazy = new Lazy<string>(() => context.Home.GoogleTagManagerNonScriptCode);
			GoogleAnalyticsCodeLazy = new Lazy<string>(() => context.Home.GoogleAnalyticsScriptCode);
            ShowJoinUsModule = context.Page.ShowJoinUsModule;
            JoinUsLazy = context.Home.JoinUs != null ? 
                        new Lazy<JoinUsViewModel>(() =>
                        new JoinUsViewModel(context.Home.JoinUs.FirstOrDefault())) : 
                        default(Lazy<JoinUsViewModel>);
        }

		public MetaTagsViewModel MetaTags => MetaTagsLazy.Value;
		public HeaderViewModel Header => HeaderLazy.Value;
		public FooterViewModel Footer => FooterLazy.Value;
		public JoinUsViewModel JoinUs => JoinUsLazy.Value;
				
		public string GoogleTagManagerScriptCode => GoogleTagManagerScriptCodeLazy.Value;
		public string GoogleTagManagerNonScriptCode => GoogleTagManagerNonScriptCodeLazy.Value;
		public string GoogleAnalyticsCode => GoogleAnalyticsCodeLazy.Value;

		private Lazy<MetaTagsViewModel> MetaTagsLazy { get; }
		private Lazy<HeaderViewModel> HeaderLazy { get; }
		private Lazy<FooterViewModel> FooterLazy { get; }
		private Lazy<JoinUsViewModel> JoinUsLazy { get; }
		
		private Lazy<string> GoogleTagManagerScriptCodeLazy { get; }
		private Lazy<string> GoogleTagManagerNonScriptCodeLazy { get; }
		private Lazy<string> GoogleAnalyticsCodeLazy { get; }

        public bool ShowJoinUsModule { get; }
    }
}
