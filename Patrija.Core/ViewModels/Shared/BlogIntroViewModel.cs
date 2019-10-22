using Patrija.Common;
using Patrija.Models.Generated;
using System;

namespace Patrija.Core.ViewModels.Shared
{
    public class BlogIntroViewModel
    {
        public BlogIntroViewModel(BlogIntro blogIntro, DateTime date, string category = null)
        {
            Guard.AgainstDefaultValue(blogIntro);
            
            Title = blogIntro.BlogIntroTitle;
            PreviewText = blogIntro.BlogIntroPreview;
            FormatedPublishDate = !Equals(date, default(DateTime)) ? date.ToString(Constants.DateFormats.DateFormatSimple) : null;
            Image = blogIntro.BlogIntroImage != null ? new ImageViewModel(blogIntro.BlogIntroImage.Url) : default(ImageViewModel);
            Category = category;
        }

        public string Title { get; }
        public string PreviewText { get; }
        public string Category { get; }
        public string FormatedPublishDate { get; }
        public ImageViewModel Image { get; }
    }
}
