using System.Web.Mvc;
using Patrija.Core.ViewModels.Pages;
using Patrija.Models.Generated;

namespace Patrija.Core.Controllers.RenderMvc
{
    public class JoinUsPageController : BasePageController<JoinUsPage>
    {
        public ActionResult Index(JoinUsPage model)
            => CurrentTemplate(new JoinUsPageViewModel(CreatePageContext(model)));
    }
}