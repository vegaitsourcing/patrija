using System;
using System.Linq;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.Home
{
    public class LinksListViewModel
    {
        public LinksListViewModel(LinksList linksList)
        {
            if (linksList == null) throw new ArgumentNullException(nameof(linksList));

            Title = linksList.LinksListTitle;
            Items = linksList.LinksListItems?.Select(li => new LinkViewModel(li)).ToArray();
        }

        public string Title { get; }
        public LinkViewModel[] Items { get; }
    }
}
