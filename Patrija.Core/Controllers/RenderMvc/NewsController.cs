using System.Web.Mvc;
using Patrija.Core.ViewModels.Pages;
using Patrija.Models.Generated;

namespace Patrija.Core.Controllers.RenderMvc
{
    public class NewsController : BasePageController<News>
    {
        public ActionResult Index(News model)
            => CurrentTemplate(new NewsViewModel(CreatePageContext(model)));
    }
}
