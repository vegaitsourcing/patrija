using System;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.Home
{
    public class HomeIntroViewModel
    {
        public HomeIntroViewModel(HomeIntro homeIntro)
        {
            if (homeIntro == null) throw new ArgumentNullException(nameof(homeIntro));

            Title = homeIntro.HomeIntroTitle;
            Link = homeIntro.HomeIntroButton != null ? new LinkViewModel(homeIntro.HomeIntroButton) : default(LinkViewModel);
            Image = homeIntro.HomeIntroImage != null ? new ImageViewModel(homeIntro.HomeIntroImage as Image) : default(ImageViewModel);
        }

        public string Title { get; }
        public LinkViewModel Link { get; }
        public ImageViewModel Image { get; }
    }
}
