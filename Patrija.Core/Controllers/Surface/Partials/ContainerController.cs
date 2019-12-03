using Patrija.Core.ViewModels.Partials.Home;
using System.Web.Mvc;

namespace Patrija.Core.Controllers.Surface.Partials
{
    public class ContainerController : BaseSurfaceController
    {
        [ChildActionOnly]
        public ActionResult HomeSupportContainer(HomeSupportViewModel viewModel)
            => PartialView(viewModel);

    }
}