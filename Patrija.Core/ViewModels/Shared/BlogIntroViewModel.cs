using Patrija.Common;
using Patrija.Models.Generated;
using System;

namespace Patrija.Core.ViewModels.Shared
{
    public class BlogIntroViewModel
    {
        public BlogIntroViewModel(BlogIntro blogIntro, string category)
        {
            Guard.AgainstDefaultValue(blogIntro);
            
            Title = blogIntro.BlogIntroTitle;
            PreviewText = blogIntro.BlogIntroPreview;
            PublishDate = blogIntro.BlogIntroDateOfPublishing.Date;
            Image = new ImageViewModel(blogIntro.BlogIntroImage as Image);
            Category = category;
        }

        public string Title { get; }
        public string PreviewText { get; }
        public string Category { get; }
        public DateTime PublishDate { get; }
        public ImageViewModel Image { get; }
    }
}
