using System;
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

            var pageIntro = context.Page.BlogArticlePageIntro != null ? context.Page.BlogArticlePageIntro.FirstOrDefault() :default(BlogIntro);
            var categoryName = context.CurrentPage.Parent.Name;
            var date = context.CurrentPage.CreateDate;
            
            BlogIntro = pageIntro != null ? new BlogIntroViewModel(pageIntro, date, categoryName) : default(BlogIntroViewModel);

            var articleContentHtml = context.Page.BlogArticleContent;
            ArticleContent = new ArticleContentViewModel(context.Page.BlogArticleSubtitle, articleContentHtml.ToHtmlString(), context.CurrentPage);
            AreCommentsEnabled = context.Page.BlogArticleShowCommentsToggle;

            PageId = context.Page.Key;
        }

        public string Title { get; }
        public BlogIntroViewModel BlogIntro { get; }
        public PageIntroViewModel PageIntro { get; }
        public string ArticleSubtitle { get; }
        public bool AreCommentsEnabled { get; }
        
        public Guid PageId { get; }
        public ArticleContentViewModel ArticleContent { get; }
    }
}