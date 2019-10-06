using System;
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

            ArticleSubtitle = context.Page.BlogArticleSubtitle;

            var articleContent = context.Page.BlogArticleContent;
            ArticleContent = articleContent.ToHtmlString();

            AreCommentsEnabled = context.Page.BlogArticleShowCommentsToggle;

            PageId = context.Page.Key;
        }

        public string Title { get; }
        
        public PageIntroViewModel PageIntro { get; }
        public string ArticleSubtitle { get; }
        public string ArticleContent { get; }
        public bool AreCommentsEnabled { get; }
        
        public Guid PageId { get; }
    }
}