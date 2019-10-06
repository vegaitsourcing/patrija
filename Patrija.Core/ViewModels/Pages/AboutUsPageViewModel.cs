using System.Linq;
using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Core.ViewModels.Partials.Home;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Pages
{
    public class AboutUsPageViewModel : PageViewModel
    {
        public AboutUsPageViewModel(IPageContext<AboutUsPage> context) : base(context)
        {
            var pageIntro = context.Page.AboutUsPageIntro;
            PageIntro = pageIntro != null ? new PageIntroViewModel(pageIntro) : null;

            var featuredProjectsContainer = context.Page.AboutUsFeaturedProjects.FirstOrDefault();
            FeaturedProjectsContainer = featuredProjectsContainer != null ? new FeaturedProjectsContainerViewModel(featuredProjectsContainer) : null;
            
            var imageWithText = context.Page.AboutUsPageImageWithText.FirstOrDefault();
            ImageWithText = imageWithText != null ? new ImageWithTextViewModel(imageWithText) : null;

            var links = context.Page.AboutUsFeaturedLinks.FirstOrDefault();
            Links = links != null ? new LinksListViewModel(links) : null;

            var joinUs = context.Page.AboutUsJoinUs.FirstOrDefault();
            JoinUs = joinUs != null ? new JoinUsViewModel(joinUs) : null;
        }

        public PageIntroViewModel PageIntro { get; }
        
        public ImageWithTextViewModel ImageWithText { get; }
        public FeaturedProjectsContainerViewModel FeaturedProjectsContainer { get; }

        public LinksListViewModel Links { get; }

        public JoinUsViewModel JoinUs { get; }
    }
}