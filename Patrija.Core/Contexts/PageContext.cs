using System;
using Umbraco.Web;
using Patrija.Models.Generated;

namespace Patrija.Core.Contexts
{
	public class PageContext<T> : SiteContext, IPageContext<T> where T : class, IPage
	{
		public PageContext(T page, UmbracoHelper umbracoHelper) : base(umbracoHelper)
		{
			Page = page ?? throw new ArgumentNullException(nameof(page));
		}

		public T Page { get; }
	}
}
