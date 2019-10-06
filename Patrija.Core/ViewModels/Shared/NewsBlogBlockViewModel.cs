using Patrija.Core.Mappers;
using Patrija.Core.ViewModels.Partials.News;
using Patrija.Models.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrija.Core.ViewModels.Shared
{
    public class NewsBlogBlockViewModel
    {
        public NewsBlogBlockViewModel(NewsBlogBlock nbb)
        {
            BlogCategoryName = nbb.NewsBlogBlockBlogCategory.Name;
            DisplayVariant = EnumMapper.MapDisplayVariant(nbb.NewsBlogBlockDisplayVariant);
            Articles = nbb.NewsBlogBlockBlogCategory.Children.OfType<BlogArticle>().Take(6).Select(article => new NewsBlogBlockPreviewViewModel(article.BlogArticlePageIntro.FirstOrDefault())).ToArray();
            LoadMoreButtonText = "TODO: Load more"; // nbb.loadMoreButtonText;
        }
        public string BlogCategoryName { get; }
        public DisplayVariant DisplayVariant { get; }
        public NewsBlogBlockPreviewViewModel[] Articles { get; }
        public string LoadMoreButtonText { get; }
    }
}
