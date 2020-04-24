using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using System.Collections.Generic;
using System.Web;

namespace Patrija.Core.ViewModels.Partials.Blog
{
    public class ArticleContentViewModel
    {
        public ArticleContentViewModel(string articleSubtitle, IHtmlString articleContentHtml, List<BlogWidgetsViewModel> widgets, CommentsBlockViewModel commentblock,  IPage page)
        {
            ArticleContentHtml = articleContentHtml;
            ArticleSubtitle = articleSubtitle;
            CurrentPage = page;
            CommentsBlock = commentblock;
            Widgets = widgets;
        }

        public string ArticleSubtitle { get; }
        public IHtmlString ArticleContentHtml { get; }
        public IPage CurrentPage { get; }
        public List<BlogWidgetsViewModel> Widgets { get; }
        public CommentsBlockViewModel CommentsBlock { get; }
    }
}
