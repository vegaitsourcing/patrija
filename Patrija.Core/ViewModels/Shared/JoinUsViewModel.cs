using Patrija.Common;
using Patrija.Core.ViewModels.Partials.JoinUs;
using Patrija.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Patrija.Core.ViewModels.Shared
{
    public class JoinUsViewModel
    {
        public JoinUsViewModel(JoinUs joinUs)
        {
            Guard.AgainstDefaultValue(joinUs);

            Title = joinUs.JoinUsTitle;
            Text = joinUs.JoinUsText;
            TopImage = joinUs.JoinUsTopImage != null ? new ImageViewModel(joinUs.JoinUsTopImage as Image) : null;
            RightImage = joinUs.JoinUsTopImage != null ? new ImageViewModel(joinUs.JoinUsRightImage as Image) : null;
            BottomImage = joinUs.JoinUsBottomImage != null ? new ImageViewModel(joinUs.JoinUsBottomImage as Image) : null;
            LeftImage = joinUs.JoinUsLeftImage != null ? new ImageViewModel(joinUs.JoinUsLeftImage as Image) : null;
            Forms = joinUs.Forms != null ? joinUs.Forms.Select(x => new JoinUsFormViewModel(x)).ToList() : new List<JoinUsFormViewModel>();
        }

        public string Title { get; }
        public string Text { get; }
        public ImageViewModel TopImage { get; }
        public ImageViewModel RightImage { get; }
        public ImageViewModel BottomImage { get; }
        public ImageViewModel LeftImage { get; }
        public List<JoinUsFormViewModel> Forms { get; }
    }
}
