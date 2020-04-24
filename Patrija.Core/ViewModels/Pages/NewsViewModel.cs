using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using System.Linq;

namespace Patrija.Core.ViewModels.Pages
{
    public class NewsViewModel : PageViewModel
    {
        public NewsViewModel(IPageContext<News> context) : base(context)
        {
            PageTitle = context.Page.PageTitle;

            var pageIntro = context.Page.NewsPageIntro;
            PageIntro = pageIntro != null ? new PageIntroViewModel(pageIntro) : null;
            
            NewsBlogBlocks = context.Page.NewsNewsBlogBlocks.Select(nbb => new NewsBlogBlockViewModel(nbb)).ToArray();
            PageId = context.Page.Id;
        }

        public string PageTitle { get; }
        public PageIntroViewModel PageIntro { get; }
        public NewsBlogBlockViewModel[] NewsBlogBlocks { get; }
        public int PageId { get; }
    }
}
