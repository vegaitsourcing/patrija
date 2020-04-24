using Patrija.Core.Mappers;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.Features
{
    public class ImageWithTextViewModel
    {
        public ImageWithTextViewModel(ImageWithText imageWithText)
        {
            Title = imageWithText.ImageWithTextTitle;
            Text = imageWithText.ImageWithTextText;
            ReadMore = imageWithText.ImageWithTextReadMore != null ? new LinkViewModel(imageWithText.ImageWithTextReadMore) : default(LinkViewModel);
            Image = imageWithText.ImageWithTextImage != null ? new ImageViewModel(imageWithText.ImageWithTextImage as Image) : default(ImageViewModel);
            ContentPosition = EnumMapper.MapContentPosition(imageWithText.ImageWithTextContentPosition);
        }
        
        public string Title { get; }
        
        public string Text { get; }
        
        public LinkViewModel ReadMore { get; }
        
        public ImageViewModel Image { get; }
        
        public ContentPosition ContentPosition { get; }
    }
}