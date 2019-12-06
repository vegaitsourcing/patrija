using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using System;
using System.Linq;

namespace Patrija.Core.ViewModels.Partials.Blog
{
    public class BlogArticlePreviewViewModel
    {
        public BlogArticlePreviewViewModel(BlogArticle blog)
        {
            Date = blog.CustomDate;

            Title = blog.BlogArticlePageIntro != null && blog.BlogArticlePageIntro.FirstOrDefault() != null ?
                    blog.BlogArticlePageIntro.FirstOrDefault().BlogIntroTitle : blog.PageTitle;

            Url = blog.Url;

            Image = blog.BlogArticlePageIntro != null && blog.BlogArticlePageIntro.FirstOrDefault() != null ?
                    new ImageViewModel(blog.BlogArticlePageIntro.FirstOrDefault().BlogIntroImage.Url) : 
                    default(ImageViewModel);
        }

        public DateTime Date { get; }
        public string Title { get; }
        public string Url { get; }
        public ImageViewModel Image { get; }
    }
}
