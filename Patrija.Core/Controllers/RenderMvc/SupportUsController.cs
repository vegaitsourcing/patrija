using System.Web.Mvc;
using Patrija.Core.ViewModels.Pages;
using Patrija.Models.Generated;

namespace Patrija.Core.Controllers.RenderMvc
{
    public class SupportUsController : BasePageController<SupportUs>
    {
        public ActionResult Index(SupportUs model)
            => CurrentTemplate(new SupportUsViewModel(CreatePageContext(model)));
    }
}