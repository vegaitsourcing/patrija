
namespace Patrija.Core.ViewModels.Partials.Blog
{
    public class ArticleContentViewModel
    {
        public ArticleContentViewModel(string articleSubtitle, string articleContentHtml)
        {
            ArticleContentHtml = articleContentHtml;
            ArticleSubtitle = articleSubtitle;
        }

        public string ArticleSubtitle { get; }
        public string ArticleContentHtml { get; }
    }
}
