using System.Web.Mvc;
using Patrija.Core.ViewModels.Pages;
using Patrija.Models.Generated;

namespace Patrija.Core.Controllers.RenderMvc
{
	public class AboutUsPageController : BasePageController<AboutUsPage>
	{
		public ActionResult Index(AboutUsPage model) 
			=> CurrentTemplate(new AboutUsPageViewModel(CreatePageContext(model)));
	}
}
