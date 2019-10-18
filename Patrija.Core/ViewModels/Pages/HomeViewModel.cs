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
                ArticleContainer = GenerateArticleContainerViewModel(context, mostRecentBlogsRequest);
            }

            Features = context.Home.FeaturedContent?.Select(f => new TaggedFeatureViewModel(f)).ToArray()
                       ?? new TaggedFeatureViewModel[0];
		    var linksList = context.Home.HomeFeaturedLinks;

            var homeSupport = context.Home.HomeSupport.FirstOrDefault();
            HomeSupport = homeSupport != null ? new HomeSupportViewModel(homeSupport) : null;

		    LinksList = linksList?.Select(ll => new LinksListViewModel(ll)).ToArray();

		    var joinUs = context.Home.HomeJoinUs.FirstOrDefault();
            JoinUs = joinUs != null ? new JoinUsViewModel(joinUs) : null;

            var aboutUs = context.Home.HomeAboutUs.FirstOrDefault();
            AboutUs = aboutUs != null ? new AboutUsViewModel(aboutUs) : null;
		}

        private static ArticleContainerViewModel GenerateArticleContainerViewModel(IPageContext<Home> context, MostRecentBlogs mostRecentBlogsRequest)
        {
            var articles = context.Home.Children.OfType<Blog>().First()
                .Children.OfType<BlogCategory>().SelectMany(category => category
                .Children.OfType<BlogArticle>().Select(bi => new ArticleViewModel(bi, category.BlogCategoryName, context.Page.CreateDate)))
                .OrderByDescending(a => a.PublishDate).Take(mostRecentBlogsRequest.MostRecentBlogsCount).ToArray();

            return new ArticleContainerViewModel(mostRecentBlogsRequest.MostRecentBlogsTitle, articles);
        }

        public HomeIntroViewModel HomeIntro { get; }
        public TaggedFeatureViewModel[] Features { get; }
        public ArticleContainerViewModel ArticleContainer { get; }
        public HomeSupportViewModel HomeSupport { get; }
        public LinksListViewModel[] LinksList { get; }
        public JoinUsViewModel JoinUs { get; }
        public AboutUsViewModel AboutUs { get; }
	}
}
