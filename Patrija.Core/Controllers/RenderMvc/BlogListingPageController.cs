using Patrija.Core.ViewModels.Pages;
using Patrija.Models.Generated;
using System.Web.Mvc;

namespace Patrija.Core.Controllers.RenderMvc
{
    public class BlogListingPageController : BasePageController<BlogListingPage>
    {
        public ActionResult Index(BlogListingPage model)
        {
            return CurrentTemplate(new BlogListingPageViewModel(CreatePageContext(model)));
        }
          
    }
}
