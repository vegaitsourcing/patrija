using Patrija.Common;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Shared
{
    public class JoinUsViewModel
    {
        public JoinUsViewModel(JoinUs joinUs)
        {
            Guard.AgainstDefaultValue(joinUs);

            Title = joinUs.JoinUsTitle;
            Text = joinUs.JoinUsText?.ToHtmlString();
            AsUserButtonText = joinUs.JoinUsAsUserButtonText;
            AsVolunteerButtonText = joinUs.JoinUsAsVolunteerButtonText;
            TopImage = joinUs.JoinUsTopImage != null ? new ImageViewModel(joinUs.JoinUsTopImage as Image) : null;
            RightImage = joinUs.JoinUsTopImage != null ? new ImageViewModel(joinUs.JoinUsRightImage as Image) : null;
            BottomImage = joinUs.JoinUsBottomImage != null ? new ImageViewModel(joinUs.JoinUsBottomImage as Image) : null;
            LeftImage = joinUs.JoinUsLeftImage != null ? new ImageViewModel(joinUs.JoinUsLeftImage as Image) : null;
        }

        public string Title { get; }
        public string Text { get; }
        public string AsUserButtonText { get; }
        public string AsVolunteerButtonText { get; }
        public ImageViewModel TopImage { get; }
        public ImageViewModel RightImage { get; }
        public ImageViewModel BottomImage { get; }
        public ImageViewModel LeftImage { get; }
    }
}
