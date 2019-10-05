using System.Web.Mvc;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Core.ViewModels.Partials.Home;

namespace Patrija.Core.Controllers.Surface.Partials
{
    public class NestedContentController : BaseSurfaceController
    {
        [ChildActionOnly]
        public ActionResult HomeIntro(HomeIntroViewModel viewModel)
            => PartialView(viewModel);
        
        [ChildActionOnly]
        public ActionResult TaggedFeature(TaggedFeatureViewModel viewModel)
            => PartialView(viewModel);
    }
}