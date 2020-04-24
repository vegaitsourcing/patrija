using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using System;

namespace Patrija.Core.ViewModels.Partials.Home
{
    public class AboutUsViewModel
    {
        public AboutUsViewModel(AboutUs aboutUs)
        {
            if (aboutUs == null) throw new ArgumentNullException(nameof(aboutUs));

            Tag = aboutUs.AboutUsTag;
            Title = aboutUs.AboutUsTitle;
            Text = aboutUs.AboutUsText;
            Link = aboutUs.AboutUsLink != null ? new LinkViewModel(aboutUs.AboutUsLink) : default(LinkViewModel);
            Image = aboutUs.AboutUsImage != null ? new ImageViewModel(aboutUs.AboutUsImage as Image) : default(ImageViewModel);
        }

        public string Tag { get; }
        public string Title { get; }
        public string Text { get; }
        public LinkViewModel Link { get; }
        public ImageViewModel Image { get; }
    }
}
