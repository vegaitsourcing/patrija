using System;
using System.Linq;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.AboutUsPage
{
    public class FeaturedProjectsContainerViewModel
    {
        public FeaturedProjectsContainerViewModel(AboutUsProjectsContainer projectsContainer)
        {
            if (projectsContainer == null) throw new ArgumentNullException(nameof(projectsContainer));

            Title = projectsContainer.AboutUsProjectsContainerMainTitle;
            UntaggedFeatures = projectsContainer.AboutUsUntaggedFeaturesContainer.Select(utgf => new UntaggedFeatureViewModel(utgf)).ToArray();
        }

        public string Title { get; }
        public UntaggedFeatureViewModel[] UntaggedFeatures { get; }
    }
}
