using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Partials.Blog;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Pages
{
    public class BlogPageViewModel : PageViewModel
    {
        public BlogPageViewModel(IPageContext<BlogArticle> context) : base(context)
        {
            Title = context.Page.PageTitle;

            var pageIntro = context.Page.BlogArticlePageIntro;

            var articleContentHtml = context.Page.BlogArticleContent;
            ArticleContent = new ArticleContentViewModel(context.Page.BlogArticleSubtitle, articleContentHtml.ToHtmlString());
        }

        public string Title { get; }
        public PageIntroViewModel PageIntro { get; }
        public ArticleContentViewModel ArticleContent { get; }
    }
}