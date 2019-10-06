using System.Linq;
using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Pages
{
    public class BlogPageViewModel : PageViewModel
    {
        public BlogPageViewModel(IPageContext<BlogArticle> context) : base(context)
        {
            Title = context.Page.PageTitle;

            var pageIntro = context.Page.BlogArticlePageIntro;
            //PageIntro = pageIntro != null ? new PageIntroViewModel(pageIntro) : null;

            ArticleSubtitle = context.Page.BlogArticleSubtitle;

            var articleContent = context.Page.BlogArticleContent;
            ArticleContent = articleContent.ToHtmlString();

        }

        public string Title { get; }
        public PageIntroViewModel PageIntro { get; }
        public string ArticleSubtitle { get; }
        public string ArticleContent { get; }

    }
}