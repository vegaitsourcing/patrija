using Patrija.Core.Mappers;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using System.Linq;

namespace Patrija.Core.ViewModels.Partials.Features
{
    public class DonationsViewModel
    {
        public DonationsViewModel(Donations donations)
        {
            Title = donations.DonationsTitle;
            Text = donations.DonationsText;
            Images = donations.DonationsLogoImages.Select(img => new ImageViewModel(img as Image)).ToArray();
        }

        public string Title { get; }
        public string Text { get; }
        public ImageViewModel[] Images { get; }
    }
}