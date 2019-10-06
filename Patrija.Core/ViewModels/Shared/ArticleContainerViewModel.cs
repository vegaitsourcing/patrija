namespace Patrija.Core.ViewModels.Shared
{
    public class ArticleContainerViewModel
    {
        public ArticleContainerViewModel(string title, ArticleViewModel[] articles, ImageViewModel backgroundImage = null)
        {
            Title = title;
            Articles = articles;
            BackgroundImage = backgroundImage;
        }

        public string Title { get; }
        public ImageViewModel BackgroundImage { get; }
        public ArticleViewModel[] Articles { get; }
    }
}
