﻿using System.Web.Mvc;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Partials.Home;
using Patrija.Core.ViewModels.Shared;

namespace Patrija.Core.Controllers.Surface.Partials
{
    public class ContainerController : BaseSurfaceController
    {
        [ChildActionOnly]
        public ActionResult AboutUsProjectsContainer(FeaturedProjectsContainerViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult HomeSupportContainer(HomeSupportViewModel viewModel)
            => PartialView(viewModel);

    }
}