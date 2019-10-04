using System;
using System.Linq;
using System.Web.Mvc;
using Patrija.Core.Extensions;
using Patrija.Core.Models;
using Patrija.Core.ViewModels.Partials.Listing;
using Patrija.Search.Services;

namespace Patrija.Core.Controllers.Surface.Partials
{
	public class SearchListingController : BaseSurfaceController
	{
		private readonly ISearchService _searchService;

		public SearchListingController(ISearchService searchService)
		{
			_searchService = searchService ?? throw new ArgumentNullException(nameof(searchService));
		}

		public ActionResult Search(string query, int page, int itemsPerPage)
		{
			if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
			if (itemsPerPage <= 0) throw new ArgumentOutOfRangeException(nameof(itemsPerPage));
			if(string.IsNullOrWhiteSpace(query)) return new EmptyResult();

			var results = _searchService.Search(query, page, itemsPerPage);
			var pagination = new Pagination(page, results.TotalResults, itemsPerPage, HttpContext.Request.Url);
			var pagedCollection = new ReadOnlyPagedCollection<SearchResultsItemViewModel>(results.Items.ToViewModel().ToList(), pagination);

			return PartialView(new ListingViewModel<SearchResultsItemViewModel>(pagedCollection));
		}
	}
}
