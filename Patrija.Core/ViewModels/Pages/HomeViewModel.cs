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

            var mostRecentBlogsRequest = context.Home.MostRecentBlogs.FirstOrDefault();
            if(mostRecentBlogsRequest != null)
            {
                var blogItems = context.Home.Children.OfType<Blog>().First().Children.OfType<BlogItem>()
                    .OrderByDescending(blogItem => blogItem?.BlogItemIntro.BlogIntroDateOfPublishing)
                    .Take(mostRecentBlogsRequest.MostRecentBlogsCount).ToArray();

                ArticleContainer = new ArticleContainerViewModel(mostRecentBlogsRequest.MostRecentBlogsTitle, blogItems.Select(bi => new ArticleViewModel(bi)).ToArray());
            }
            
            Features = context.Home.FeaturedContent?.Select(f => new TaggedFeatureViewModel(f)).ToArray()
                       ?? new TaggedFeatureViewModel[0];
		    var linksList = context.Home.HomeFeaturedLinks;
		    LinksList = linksList?.Select(ll => new LinksListViewModel(ll)).ToArray();

		    var joinUs = context.Home.HomeJoinUs.FirstOrDefault();
            JoinUs = joinUs != null ? new JoinUsViewModel(joinUs) : null;
		}

        public HomeIntroViewModel HomeIntro { get; }
        
        public TaggedFeatureViewModel[] Features { get; }
        public ArticleContainerViewModel ArticleContainer { get; }
        public LinksListViewModel[] LinksList { get; }
        public JoinUsViewModel JoinUs { get; }
	}
}
