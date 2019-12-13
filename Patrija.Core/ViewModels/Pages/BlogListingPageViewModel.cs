using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Partials.Blog;
using Patrija.Models.Extensions;
using Patrija.Models.Generated;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web;

namespace Patrija.Core.ViewModels.Pages
{
    public class BlogListingPageViewModel : PageViewModel
    {
        public BlogListingPageViewModel(IPageContext<BlogListingPage> context) : base(context)
        {
            var pageIntro = context.Page.Intro;
            PageIntro = pageIntro != null ? new PageIntroViewModel(pageIntro) : null;
            Text = context.Page.Text;
            Blogs = context.Page.DescendantsOrSelf().OfType<BlogArticle>().Select(ba => new BlogArticlePreviewViewModel(ba)).ToList();

        }

        public PageIntroViewModel PageIntro { get; }

        public IHtmlString Text { get; }

        public List<BlogArticlePreviewViewModel> Blogs { get; }
    }
}