using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.Blog
{
    public class ArticleContentViewModel
    {
        public ArticleContentViewModel(string articleSubtitle, string articleContentHtml, IPage page)
        {
            ArticleContentHtml = articleContentHtml;
            ArticleSubtitle = articleSubtitle;
            CurrentPage = page;
        }

        public string ArticleSubtitle { get; }
        public string ArticleContentHtml { get; }
        public IPage CurrentPage { get; }
    }
}
