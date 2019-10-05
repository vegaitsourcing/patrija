using System.Linq;
using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Core.ViewModels.Partials.Home;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Pages
{
	public class HomeViewModel : PageViewModel
	{
		public HomeViewModel(IPageContext<Home> context) : base(context)
		{
		    var homeIntro = context.Home.HomeIntro.FirstOrDefault();
            HomeIntro = homeIntro != null ? new HomeIntroViewModel(homeIntro) : null;

            Features = context.Home.FeaturedContent?.Select(f => new TaggedFeatureViewModel(f)).ToArray()
                       ?? new TaggedFeatureViewModel[0];
		    var linksList = context.Home.HomeFeaturedLinks;
		    LinksList = linksList?.Select(ll => new LinksListViewModel(ll)).ToArray();

		    var joinUs = context.Home.HomeJoinUs.FirstOrDefault();
            JoinUs = joinUs != null ? new JoinUsViewModel(joinUs) : null;

            var aboutUs = context.Home.HomeAboutUs.FirstOrDefault();
            AboutUs = aboutUs != null ? new AboutUsViewModel(aboutUs) : null;
		}

        public HomeIntroViewModel HomeIntro { get; }
        public TaggedFeatureViewModel[] Features { get; }
        public HomeSupportViewModel HomeSupport { get; }
        public LinksListViewModel[] LinksList { get; }
        public JoinUsViewModel JoinUs { get; }
        public AboutUsViewModel AboutUs { get; }
	}
}
