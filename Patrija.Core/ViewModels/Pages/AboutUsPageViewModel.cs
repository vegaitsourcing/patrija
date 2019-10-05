using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Pages
{
    public class AboutUsPageViewModel : PageViewModel
    {
        public AboutUsPageViewModel(IPageContext<AboutUsPage> context) : base(context)
        {
            var pageIntro = context.Page.AboutUsPageIntro;
            PageIntro = pageIntro != null ? new PageIntroViewModel(pageIntro) : null;
        }

        public PageIntroViewModel PageIntro { get; }
    }
}