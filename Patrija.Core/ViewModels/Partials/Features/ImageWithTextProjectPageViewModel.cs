using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.Features
{
    public class ImageWithTextProjectPageViewModel
    {
        public ImageWithTextProjectPageViewModel(ImageWithTextProjectPage imageWithText)
        {
            Title = imageWithText.ImageWithTextTitle;
            Text = imageWithText.ImageWithTextText;
            Image = imageWithText.ImageWithTextImage != null ? new ImageViewModel(imageWithText.ImageWithTextImage as Image) : default(ImageViewModel);
        }

        public string Title { get; }

        public string Text { get; }

        public ImageViewModel Image { get; }

    }
}
