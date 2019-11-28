using Patrija.Common;
using Patrija.Models.Generated;
using System;
using System.Linq;

namespace Patrija.Core.ViewModels.Shared
{
    public class ArticleViewModel
    {
        
        public ArticleViewModel(BlogArticle blogArticle, string category)
        {
            Guard.AgainstDefaultValue(blogArticle);
            Guard.AgainstDefaultValue(blogArticle.BlogArticlePageIntro);

            var blogIntro = blogArticle.BlogArticlePageIntro.FirstOrDefault();

            Title = blogIntro.BlogIntroTitle;
            PreviewText = blogIntro.BlogIntroPreview;
            Date = blogArticle.CustomDate;
            Image = blogIntro.BlogIntroImage != null ? new ImageViewModel(blogIntro.BlogIntroImage as Image) : default(ImageViewModel);
            BlogPageUrl = blogArticle.Url;
            Category = category;
        }

        public bool HasMetadata => !string.IsNullOrEmpty(Category) || Date != null;

        public string Title { get; }
        public string PreviewText { get; }
        public string Category { get; }
        public string BlogPageUrl { get; }
        public DateTime Date { get; }
        public ImageViewModel Image { get; }
    }
}
