using System;
using System.Linq;
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
            FeatureImage = new ImageViewModel(untaggedFeature.FeatureImage as Image);
            AdditionalImage = new ImageViewModel(untaggedFeature.FeatureAdditionalImage as Image);
        }

        public string Title { get; }
        public string Text { get; }
        public LinkViewModel Link { get; }
        public string ContentPosition { get; }
        public ImageViewModel FeatureImage { get; }
        public ImageViewModel AdditionalImage { get; }


    }
}
