using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Link = new LinkViewModel(aboutUs.AboutUsLink);
            Image = new ImageViewModel(aboutUs.AboutUsImage as Image);
        }

        public string Tag { get; }
        public string Title { get; }
        public string Text { get; }
        public LinkViewModel Link { get; }
        public ImageViewModel Image { get; }
    }
}
