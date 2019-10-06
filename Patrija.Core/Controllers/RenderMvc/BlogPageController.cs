using System.Web.Mvc;
using Patrija.Core.ViewModels.Pages;
using Patrija.Models.Generated;

namespace Patrija.Core.Controllers.RenderMvc
{
	public class BlogPageController : BasePageController<BlogArticle>
	{
		public ActionResult Index(BlogArticle model) 
			=> CurrentTemplate(new BlogPageViewModel(CreatePageContext(model)));
	}
}
