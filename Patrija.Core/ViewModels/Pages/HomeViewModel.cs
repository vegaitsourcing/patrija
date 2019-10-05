using System.Linq;
using Patrija.Core.Contexts;
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
            
            
            var blogItems = context.Home.Children.OfType<Blog>().First().Children.OfType<BlogItem>().ToArray();

            var linksList = context.Home.HomeFeaturedLinks;
		    LinksList = linksList?.Select(ll => new LinksListViewModel(ll)).ToArray();
		}

        public HomeIntroViewModel HomeIntro { get; }
        public ArticleContainerViewModel ArticleContainer { get; }
        public LinksListViewModel[] LinksList { get; }
	}
}
