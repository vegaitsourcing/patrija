using Patrija.Core.ViewModels.Partials.Share;
using Patrija.Models.Generated;
using System.Web.Mvc;

namespace Patrija.Core.Controllers.Surface.Partials
{
    public class SharedController : BaseSurfaceController
	{
        [ChildActionOnly]
        public ActionResult Share(IPage page)
        {
            ShareViewModel viewModel = new ShareViewModel(page);
            viewModel.CurrentPage = page;
            return PartialView(viewModel);
        }

    }
}
