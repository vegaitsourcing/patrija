using Patrija.Models.Generated;
using System;
using System.Linq;

namespace Patrija.Core.ViewModels.Shared
{
    public class NewsBlogBlockPreviewViewModel
    {
        public NewsBlogBlockPreviewViewModel(BlogArticle model)
        {
            BlogIntro = model.BlogArticlePageIntro != null ? new BlogIntroViewModel(model.BlogArticlePageIntro.FirstOrDefault(), model.CreateDate) : default(BlogIntroViewModel);
            Url = model.Url;
        }

        public string Url { get; }
        public BlogIntroViewModel BlogIntro { get; }
    }
}