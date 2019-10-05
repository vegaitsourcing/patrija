using System.Linq;
using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Pages
{
    public class AboutUsPageViewModel : PageViewModel
    {
        public AboutUsPageViewModel(IPageContext<AboutUsPage> context) : base(context)
        {
            var pageIntro = context.Page.AboutUsPageIntro;
            PageIntro = pageIntro != null ? new PageIntroViewModel(pageIntro) : null;
            
            var imageWithText = context.Page.AboutUsPageImageWithText.FirstOrDefault();
            ImageWithText = imageWithText != null ? new ImageWithTextViewModel(imageWithText) : null;
        }

        public PageIntroViewModel PageIntro { get; }
        
        public ImageWithTextViewModel ImageWithText { get; }
    }
}