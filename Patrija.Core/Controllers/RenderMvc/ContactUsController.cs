using System.Web.Mvc;
using Patrija.Core.ViewModels.Pages;
using Patrija.Models.Generated;

namespace Patrija.Core.Controllers.RenderMvc
{
    public class ContactUsController : BasePageController<ContactUs>
    {
        public ActionResult Index(ContactUs model)
            => CurrentTemplate(new ContactUsViewModel(CreatePageContext(model)));
    }
}