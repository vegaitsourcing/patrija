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
            PublishDate = blogItem.BlogItemIntro.BlogIntroDateOfPublishing;
            Image = new ImageViewModel(blogItem.BlogItemIntro.BlogIntroImage as Image);
        }

        public string Title { get; }
        public string PreviewText { get; }
        public DateTime PublishDate { get; }
        public ImageViewModel Image { get; }
    }
}
