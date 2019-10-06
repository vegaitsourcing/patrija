using Patrija.Models.Generated;
using System;

namespace Patrija.Core.ViewModels.Shared
{
    public class NewsBlogBlockPreviewViewModel
    {
        public NewsBlogBlockPreviewViewModel(BlogIntro blogArticlePageIntro)
        {
            //this.blogArticlePageIntro = blogArticlePageIntro;
            DateOfPublishing = blogArticlePageIntro.BlogIntroDateOfPublishing;
            Image = new ImageViewModel(blogArticlePageIntro.BlogIntroImage.Url);
            Title = blogArticlePageIntro.BlogIntroTitle;
        }

        public DateTime DateOfPublishing { get; }
        public ImageViewModel Image { get; }
        public string Title { get; }
    }
}