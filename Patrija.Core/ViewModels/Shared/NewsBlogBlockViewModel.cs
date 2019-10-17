using Patrija.Common;
using Patrija.Core.Mappers;
using Patrija.Core.ViewModels.Partials.News;
using Patrija.Models.Extensions;
using Patrija.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Patrija.Core.ViewModels.Shared
{
    public class NewsBlogBlockViewModel
    {
        public NewsBlogBlockViewModel(NewsBlogBlock model)
        {
            BlogCategoryName = model.NewsBlogBlockBlogCategory.Name;
            DisplayVariant = EnumMapper.MapDisplayVariant(model.NewsBlogBlockDisplayVariant);
            TotalNumberOfExistingArticles = model.GetNumberOfArticles();
            NumberOfArticlesOnLoad = AppSettings.NumberOfArticlesOnLoad;
            FeatureArticle = model.GetFirstArticle() != null ? new NewsBlogBlockPreviewViewModel(model.GetFirstArticle()) : default(NewsBlogBlockPreviewViewModel);
            RightArticles = model.GetOnLoadArticlesSkippingFirst(NumberOfArticlesOnLoad)
                        .Select(article => article != null ?
                                    new NewsBlogBlockPreviewViewModel(article)
                                    : null)
                        .ToList();
        }
        public string BlogCategoryName { get; }
        public DisplayVariant DisplayVariant { get; }
        public IReadOnlyList<NewsBlogBlockPreviewViewModel> RightArticles { get; }
        public IReadOnlyList<NewsBlogBlockPreviewViewModel> AllArticles { get; }
        public NewsBlogBlockPreviewViewModel FeatureArticle { get; }

        public int TotalNumberOfExistingArticles { get; }
        public int NumberOfArticlesOnLoad { get; }
    }
}
