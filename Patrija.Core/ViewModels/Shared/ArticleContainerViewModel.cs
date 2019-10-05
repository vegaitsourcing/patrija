namespace Patrija.Core.ViewModels.Shared
{
    public class ArticleContainerViewModel
    {
        public ArticleContainerViewModel(string title, ArticleViewModel[] articles)
        {
            Title = title;
            Articles = articles;
        }

        public string Title { get; }
        public ArticleViewModel[] Articles { get; }
    }
}
