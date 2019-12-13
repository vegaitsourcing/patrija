using Patrija.Core.ViewModels.Pages;
using Patrija.Models.Generated;
using System.Web.Mvc;

namespace Patrija.Core.Controllers.RenderMvc
{
    public class EnglishPageController : BasePageController<EnglishPage>
    {
        public ActionResult Index(EnglishPage model)
            => CurrentTemplate(new EnglishPageViewModel(CreatePageContext(model)));
    }
}
