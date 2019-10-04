using System.Web.Mvc;
using Patrija.Core.Extensions;
using Patrija.Core.ViewModels.Pages;
using Patrija.Models.Generated;

namespace Patrija.Core.Controllers.RenderMvc
{
	public class SearchResultsController : BasePageController<SearchResults>
	{
		public ActionResult Index(SearchResults model)
			=> CurrentTemplate(
				new SearchResultsViewModel(CreatePageContext(model), 
				Request.GetQueryParameter(),
				Request.GetPageParameter()));
	}
}
