using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrija.Core.ViewModels.Shared
{
    public class NewsListViewModel
    {
        public NewsListViewModel(string title, ArticleViewModel[] articles, string loadMoreButtonText)
        {
            Title = title;
            Articles = articles;
            LoadMoreButtonText = loadMoreButtonText;
        }

        public string Title { get; }
        public ArticleViewModel[] Articles { get; }
        public string LoadMoreButtonText { get; }
        public string Count { get; }
    }
}
