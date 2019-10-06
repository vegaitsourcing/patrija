using System;
using Patrija.Core.Mappers;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.AboutUsPage
{
    public class FeatruedProjectViewModel
    {
        public FeatruedProjectViewModel(UntaggedFeature untaggedFeature)
        {
            if (untaggedFeature == null) throw new ArgumentNullException(nameof(untaggedFeature));

            Title = untaggedFeature.FeatureTitle;
            Text = untaggedFeature.FeatureText;
            Link = new LinkViewModel(untaggedFeature.FeatureReadMoreLink);
            ContentPosition = EnumMapper.MapContentPosition(untaggedFeature.FeatureContentPosition);
            FeatureImage = new ImageViewModel(untaggedFeature.FeatureImage as Image);
            AdditionalImage = new ImageViewModel(untaggedFeature.FeatureAdditionalImage as Image);
        }

        public string Title { get; }
        public string Text { get; }
        public LinkViewModel Link { get; }
        public ContentPosition ContentPosition { get; }
        public ImageViewModel FeatureImage { get; }
        public ImageViewModel AdditionalImage { get; }


    }
}
