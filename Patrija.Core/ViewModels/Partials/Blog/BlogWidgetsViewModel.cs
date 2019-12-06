using Patrija.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Patrija.Core.ViewModels.Partials.Blog
{
    public class BlogWidgetsViewModel
    {
        public BlogWidgetsViewModel(BlogWidgets widgets)
        {
            Blogs = widgets.Blogs != null ?
                     widgets.Blogs.OfType<BlogArticle>().Select(b => new BlogArticlePreviewViewModel(b)).ToList() :
                     default(List<BlogArticlePreviewViewModel>);

            Title = widgets.Title;
        }

        public List<BlogArticlePreviewViewModel> Blogs { get; }
        public string Title { get; }
    }
}
