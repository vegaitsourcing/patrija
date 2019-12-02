using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using Umbraco.Web.Models;

namespace Patrija.Core.ViewModels.Partials.Features
{
    public class TaggedFeatureViewModel : FeatureViewModel
    {
        public TaggedFeatureViewModel(TaggedFeature feature, string url = null)
            : base(feature)
        {
            Tag = feature.TaggedFeatureTag;
            ReadMore = url != null ? new LinkViewModel(new Link { Url = url, Name = UmbracoDictionary.Common.ReadMore}) : default(LinkViewModel);
        }
        
        public string Tag { get; }
        public string Url { get; }
    }
}