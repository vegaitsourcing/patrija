using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using Umbraco.Web.Models;

namespace Patrija.Core.ViewModels.Partials.Features
{
    public class TaggedFeatureViewModel : FeatureViewModel
    {
        public TaggedFeatureViewModel(TaggedFeature feature, string url = null, bool? aboutUs = null, bool? currentProjects = null)
            : base(feature)
        {
            Tag = feature.TaggedFeatureTag;
            AboutUsPage = aboutUs;
            CurrentProjects = currentProjects;
            ReadMore = url != null ? new LinkViewModel(new Link { Url = url, Name = UmbracoDictionary.Common.ReadMore }) : default(LinkViewModel);
        }

        public string Tag { get; }
        public bool? AboutUsPage { get; }
        public bool? CurrentProjects { get; }
    }
}