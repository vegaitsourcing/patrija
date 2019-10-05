using System.Web.Mvc;
using Patrija.Core.ViewModels.Pages;
using Patrija.Models.Generated;

namespace Patrija.Core.Controllers.RenderMvc
{
	public class PageVariant1Controller : BasePageController<PageVariant1>
	{
        public ActionResult Index(PageVariant1 model)
            => CurrentTemplate(new PageVariant1ViewModel(CreatePageContext(model)));
    }
}
