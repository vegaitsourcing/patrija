using Patrija.Models.Generated;
using System;

namespace Patrija.Core.ViewModels.Shared
{
    public class ArticleViewModel
    {
        public ArticleViewModel(BlogItem blogItem)
        {
            if (blogItem == null) { throw new ArgumentNullException(nameof(blogItem)); }
            if (blogItem.BlogItemIntro == null) { throw new ArgumentNullException(nameof(blogItem.BlogItemIntro)); }

            Title = blogItem.BlogItemIntro.BlogIntroTitle;
            PreviewText = blogItem.BlogItemIntro.BlogIntroPreview;
            PublishDate = blogItem.BlogItemIntro.BlogIntroDateOfPublishing.Date;
            Image = new ImageViewModel(blogItem.BlogItemIntro.BlogIntroImage as Image);
            BlogPageUrl = blogItem.Url;
        }

        public bool HasMetadata => !string.IsNullOrEmpty(Category) || PublishDate != null;

        public string Title { get; }
        public string PreviewText { get; }
        public string Category { get; }
        public string BlogPageUrl { get; } 
        public DateTime PublishDate { get; }
        public ImageViewModel Image { get; }
    }
}
