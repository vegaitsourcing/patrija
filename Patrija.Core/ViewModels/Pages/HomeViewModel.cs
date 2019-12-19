using System.Linq;
using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
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
		    var homeIntro = context.Home.HomeIntro;
            HomeIntro = homeIntro != null ? new PageIntroViewModel(homeIntro) : null;

            var mostRecentBlogsRequest = context.Home.MostRecentBlogs.FirstOrDefault();

            if(mostRecentBlogsRequest != null)
            {
                ArticleContainer = GenerateArticleContainerViewModel(context, mostRecentBlogsRequest);
            }

            Features = context.Home.Projects?.OfType<ProjectPage>().Select(f => new TaggedFeatureViewModel(f.PreviewInfo.FirstOrDefault(), f.Url)).ToArray()
                       ?? new TaggedFeatureViewModel[0];
		    var linksList = context.Home.HomeFeaturedLinks;

            var homeSupport = context.Home.HomeSupport.FirstOrDefault();
            HomeSupport = homeSupport != null ? new HomeSupportViewModel(homeSupport) : null;

		    LinksList = linksList?.Select(ll => new LinksListViewModel(ll)).ToArray();

            var aboutUs = context.Home.HomeAboutUs.FirstOrDefault();
            AboutUs = aboutUs != null ? new AboutUsViewModel(aboutUs) : null;
		}

        private static ArticleContainerViewModel GenerateArticleContainerViewModel(IPageContext<Home> context, MostRecentBlogs mostRecentBlogsRequest)
        {
            var articles = context.Home.Children.OfType<BlogListingPage>().First()
                .Children.OfType<BlogCategory>().SelectMany(category => category
                .Children.OfType<BlogArticle>().Select(bi => new ArticleViewModel(bi, category.BlogCategoryName)))
                .OrderByDescending(a => a.Date).Take(mostRecentBlogsRequest.MostRecentBlogsCount).ToArray();

            return new ArticleContainerViewModel(mostRecentBlogsRequest.MostRecentBlogsTitle, articles);
        }

        public PageIntroViewModel HomeIntro { get; }
        public TaggedFeatureViewModel[] Features { get; }
        public ArticleContainerViewModel ArticleContainer { get; }
        public HomeSupportViewModel HomeSupport { get; }
        public LinksListViewModel[] LinksList { get; }
        public AboutUsViewModel AboutUs { get; }
	}
}
