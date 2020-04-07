using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Core.ViewModels.Partials.Home;
using Patrija.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Patrija.Core.ViewModels.Pages
{
    public class AboutUsPageViewModel : PageViewModel
    {
        public AboutUsPageViewModel(IPageContext<AboutUsPage> context) : base(context)
        {
            var pageIntro = context.Page.AboutUsPageIntro;
            PageIntro = pageIntro != null ? new PageIntroViewModel(pageIntro) : null;

            var featuredProjectsContainer = context.Page.CurrentProjects.FirstOrDefault();
            CurrentProjects = context.Page.CurrentProjects?.OfType<ProjectPage>().Select(f => new TaggedFeatureViewModel(f.PreviewInfo.FirstOrDefault(), f.Url, true, true)).ToList()
                       ?? new List<TaggedFeatureViewModel>();
            FinishedProjects = context.Page.FinishedProjects?.OfType<ProjectPage>().Select(f => new TaggedFeatureViewModel(f.PreviewInfo.FirstOrDefault(), f.Url, true, false)).ToList()
                      ?? new List<TaggedFeatureViewModel>();

            var imageWithText = context.Page.AboutUsPageImageWithText.FirstOrDefault();
            ImageWithText = imageWithText != null ? new ImageWithTextViewModel(imageWithText) : null;

            var links = context.Page.AboutUsFeaturedLinks.FirstOrDefault();
            Links = links != null ? new LinksListViewModel(links) : null;

        }

        public PageIntroViewModel PageIntro { get; }
        
        public ImageWithTextViewModel ImageWithText { get; }
        public List<TaggedFeatureViewModel> CurrentProjects { get; }
        public List<TaggedFeatureViewModel> FinishedProjects { get; }

        public LinksListViewModel Links { get; }
    }
}