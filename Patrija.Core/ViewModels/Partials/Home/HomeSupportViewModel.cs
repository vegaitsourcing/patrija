using System;
using System.Linq;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.Home
{
    public class HomeSupportViewModel
    {
        public HomeSupportViewModel(HomeSupport homeSupport)
        {
            if (homeSupport == null) throw new ArgumentNullException(nameof(homeSupport));

            supportContentBoxViewModels = homeSupport.HomeSupportContentBoxes.Select(scb => new SupportContentBoxViewModel(scb)).ToArray();
            Image = new ImageViewModel(homeSupport.HomeSupportImage as Image);
        }

        public SupportContentBoxViewModel[] supportContentBoxViewModels { get; }
        public ImageViewModel Image { get; }

    }
}
