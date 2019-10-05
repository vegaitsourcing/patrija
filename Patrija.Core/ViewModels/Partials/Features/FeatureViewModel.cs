using Patrija.Core.Mappers;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.Features
{
    public class FeatureViewModel
    {
        public FeatureViewModel(IFeature feature)
        {
            Title = feature.FeatureTitle;
            Text = feature.FeatureText;
            ReadMore = new LinkViewModel(feature.FeatureReadMoreLink);
            ContentPosition = EnumMapper.MapContentPosition(feature.FeatureContentPosition);
            Image = new ImageViewModel(feature.FeatureImage as Image);
            AdditionalImage = feature.FeatureAdditionalImage != null 
                ? new ImageViewModel(feature.FeatureAdditionalImage as Image) 
                : null;
        }
        
        public string Title { get; }
        
        public string Text { get; }
        
        public LinkViewModel ReadMore { get; }
        
        public ContentPosition ContentPosition { get; }
        
        public ImageViewModel Image { get; }
        
        public ImageViewModel AdditionalImage { get; }
    }
}