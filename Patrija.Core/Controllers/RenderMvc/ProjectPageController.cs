using System.Web.Mvc;
using Patrija.Core.ViewModels.Pages;
using Patrija.Models.Generated;

namespace Patrija.Core.Controllers.RenderMvc
{
	public class ProjectPageController : BasePageController<ProjectPage>
	{
		public ActionResult Index(ProjectPage model) 
			=> CurrentTemplate(new ProjectPageViewModel(CreatePageContext(model)));
	}
}
