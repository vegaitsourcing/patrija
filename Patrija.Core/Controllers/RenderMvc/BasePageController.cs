using Umbraco.Web.Mvc;
using Patrija.Core.Contexts;
using Patrija.Core.Extensions;
using Patrija.Models.Generated;

namespace Patrija.Core.Controllers.RenderMvc
{
	public abstract class BasePageController<T> : RenderMvcController where T : class, IPage
	{
		protected IPageContext<T> CreatePageContext(T page) => Umbraco.CreatePageContext(page);
	}
}
