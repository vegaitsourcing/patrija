using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.Features
{
    public class TaggedFeatureViewModel : FeatureViewModel
    {
        public TaggedFeatureViewModel(TaggedFeature feature)
            : base(feature)
        {
            Tag = feature.TaggedFeatureTag;
        }
        
        public string Tag { get; }
    }
}