using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Models.Generated;
using System.Web;

namespace Patrija.Core.ViewModels.Pages
{
    public class EnglishPageViewModel : PageViewModel
    {
        public EnglishPageViewModel(IPageContext<EnglishPage> context) : base(context)
        {
            var pageIntro = context.Page.Intro;
            PageIntro = pageIntro != null ? new PageIntroViewModel(pageIntro) : null;

            Text = context.Page.Text;

        }

        public PageIntroViewModel PageIntro { get; }

        public IHtmlString Text { get; }
    }
}