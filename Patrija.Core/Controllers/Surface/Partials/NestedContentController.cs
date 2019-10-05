﻿using System.Web.Mvc;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Core.ViewModels.Partials.Home;
using Patrija.Core.ViewModels.Shared;

namespace Patrija.Core.Controllers.Surface.Partials
{
    public class NestedContentController : BaseSurfaceController
    {
        [ChildActionOnly]
        public ActionResult PageIntro(PageIntroViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult HomeIntro(HomeIntroViewModel viewModel)
            => PartialView(viewModel);
        
        [ChildActionOnly]
        public ActionResult TaggedFeature(TaggedFeatureViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult LinksList(LinksListViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult HomeSupport(HomeSupportViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult JoinUs(JoinUsViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult AboutUs(AboutUsViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult SimpleForm(SimpleFormViewModel viewModel)
            => PartialView(viewModel);
    }
}