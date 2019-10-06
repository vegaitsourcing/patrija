using Patrija.Common;
using Patrija.Models.Generated;
using System.Linq;

namespace Patrija.Core.ViewModels.Shared
{
    public class ImageContainerViewModel
    {
        public ImageContainerViewModel(ImageContainer imageContainer)
        {
            Guard.AgainstDefaultValue(imageContainer);
            Guard.AgainstDefaultValue(imageContainer.ImageContainerItems);

            Title = imageContainer.ImageContainerTitle;
            Images = imageContainer.ImageContainerItems.Select(image => new ImageViewModel(image as Image)).ToArray();
        }

        public string Title { get; }
        public ImageViewModel[] Images { get; }
    }
}
