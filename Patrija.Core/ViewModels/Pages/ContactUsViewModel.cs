using System.Linq;
using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Pages
{
    //public class ContactUsViewModel : PageViewModel
    //{
    //    public AboutUsPageViewModel(IPageContext<AboutUsPage> context) : base(context)
    //    {
    //        var pageIntro = context.Page.AboutUsPageIntro;
    //        PageIntro = pageIntro != null ? new PageIntroViewModel(pageIntro) : null;

    //        var featuredProjectsContainer = context.Page.AboutUsFeaturedProjects.FirstOrDefault();
    //        FeaturedProjectsContainer = featuredProjectsContainer != null ? new FeaturedProjectsContainerViewModel(featuredProjectsContainer) : null;

    //        var imageWithText = context.Page.AboutUsPageImageWithText.FirstOrDefault();
    //        ImageWithText = imageWithText != null ? new ImageWithTextViewModel(imageWithText) : null;
    //    }
    //}
}