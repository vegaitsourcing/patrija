using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Partials.Blog;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using System.Linq;

namespace Patrija.Core.ViewModels.Pages
{
    public class BlogPageViewModel : PageViewModel
    {
        public BlogPageViewModel(IPageContext<BlogArticle> context) : base(context)
        {
            Title = context.Page.PageTitle;

            var pageIntro = context.Page.BlogArticlePageIntro.FirstOrDefault();
            var categoryName = context.CurrentPage.Parent.Name;
            
            BlogIntro = new BlogIntroViewModel(pageIntro, categoryName);

            var articleContentHtml = context.Page.BlogArticleContent;
            ArticleContent = new ArticleContentViewModel(context.Page.BlogArticleSubtitle, articleContentHtml.ToHtmlString());
        }

        public string Title { get; }
        public BlogIntroViewModel BlogIntro { get; }
        public ArticleContentViewModel ArticleContent { get; }
    }
}