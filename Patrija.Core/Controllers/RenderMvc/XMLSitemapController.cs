using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Patrija.Core.ViewModels.Pages;
using Patrija.Models.DocumentTypes;

namespace Patrija.Core.Controllers.RenderMvc
{
	public class XMLSitemapController : RenderMvcController
	{
		public ActionResult XMLSitemap(IDomainRoot model)
			=> CurrentTemplate(new XMLSitemapViewModel(model));
	}
}
