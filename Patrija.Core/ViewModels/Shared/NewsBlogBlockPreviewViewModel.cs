using Patrija.Models.Generated;
using System;
using System.Linq;

namespace Patrija.Core.ViewModels.Shared
{
    public class NewsBlogBlockPreviewViewModel
    {
        public NewsBlogBlockPreviewViewModel(BlogArticle model)
        {
            BlogIntro = model != null && model.BlogArticlePageIntro != null ? model.BlogArticlePageIntro.FirstOrDefault() : default(BlogIntro);
            DateOfPublishing = BlogIntro != null ? BlogIntro.BlogIntroDateOfPublishing : default(DateTime);
            Image = BlogIntro != null && BlogIntro.BlogIntroImage != null ? new ImageViewModel(BlogIntro.BlogIntroImage.Url) : default(ImageViewModel);
            Title = BlogIntro != null ? BlogIntro.BlogIntroTitle : string.Empty;
            Url = model.Url;
        }

        public DateTime DateOfPublishing { get; }
        public ImageViewModel Image { get; }
        public string Title { get; }
        public string Url { get; }
        public BlogIntro BlogIntro { get; }
    }
}