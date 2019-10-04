using System;
using System.Web;
using System.Web.Mvc;
using Patrija.Search.Models;

namespace Patrija.Core.ViewModels.Partials.Listing
{
	public class SearchResultsItemViewModel
	{
		public SearchResultsItemViewModel(ISearchResultItem model)
		{
			if (model == null) throw new ArgumentNullException(nameof(model));

			Title = model.GetTitle();
			Summary = new MvcHtmlString(model.GetSummaryText());
			Url = model.GetUrl();
		}

		public string Title { get; }
		public IHtmlString Summary { get; }
		public string Url { get; }
	}
}
