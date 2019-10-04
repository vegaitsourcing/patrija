using System.Collections.Generic;
using System.Linq;
using Patrija.Core.ViewModels.Pages;
using Patrija.Core.ViewModels.Partials.Listing;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using Patrija.Models.DocumentTypes;
using Patrija.Search.Models;

namespace Patrija.Core.Extensions
{
	public static class ViewModelExtensions
	{
		public static ImageViewModel ToViewModel(this Image image)
			=> image != null ? new ImageViewModel(image) : default(ImageViewModel);

		public static XMLSitemapItemViewModel ToViewModel(this ISeo page)
			=> page != null ? new XMLSitemapItemViewModel(page) : default(XMLSitemapItemViewModel);

		public static SearchResultsItemViewModel ToViewModel(this ISearchResultItem item)
			=> new SearchResultsItemViewModel(item);

		public static IEnumerable<SearchResultsItemViewModel> ToViewModel(this IEnumerable<ISearchResultItem> items)
		{
			if (items == null) return Enumerable.Empty<SearchResultsItemViewModel>();

			return items.Select(ToViewModel);
		}
	}
}
