using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Models.Generated;
using System.Linq;

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
        }

        public PageIntroViewModel PageIntro { get; }
        public FeaturedProjectsContainerViewModel FeaturedProjectsContainer { get; }
    }
}