using System.Web.Mvc;
using Patrija.Core.ViewModels.Pages;
using Patrija.Models.Generated;

namespace Patrija.Core.Controllers.RenderMvc
{
	public class HomeController : BasePageController<Home>
	{
		public ActionResult Index(Home model) 
			=> CurrentTemplate(new HomeViewModel(CreatePageContext(model)));
	}
}
