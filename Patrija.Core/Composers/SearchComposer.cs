using Examine;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Web;
using Patrija.Search.Services;
using Patrija.Search.Services.Implementation;

namespace Patrija.Core.Composers
{
	public class SearchComposer : IUserComposer
	{
		public void Compose(Composition composition)
		{
			composition.RegisterFor<ISearchService, SearchService>(f => new SearchService(f.GetInstance<IExamineManager>(), f.GetInstance<IUmbracoContextAccessor>()));
		}
	}
}
