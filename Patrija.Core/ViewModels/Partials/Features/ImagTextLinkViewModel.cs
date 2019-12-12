using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.Features
{
    public class ImageTextLinkViewModel
    {
        public ImageTextLinkViewModel(ImageTextLink model)
        {
            Title = model.ImageWithTextTitle;
            Text = model.ImageWithTextText;
            Image = model.ImageWithTextImage != null ? new ImageViewModel(model.ImageWithTextImage as Image) : default(ImageViewModel);
            Link = model.ImageWithTextReadMore != null ? new LinkViewModel(model.ImageWithTextReadMore) : default(LinkViewModel);
        }

        public string Title { get; }

        public string Text { get; }

        public LinkViewModel Link { get; }

        public ImageViewModel Image { get; }

    }
}
