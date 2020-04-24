using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Models.Generated;
using System;
using System.Linq;

namespace Patrija.Core.ViewModels.Partials.AboutUsPage
{
    public class FeaturedProjectsContainerViewModel
    {
        //public FeaturedProjectsContainerViewModel(AboutUsProjectsContainer projectsContainer)
        //{
        //    if (projectsContainer == null) throw new ArgumentNullException(nameof(projectsContainer));

        //    Title = UmbracoDictionary.
        //    UntaggedFeatures = projectsContainer.AboutUsUntaggedFeaturesContainer.Select(utgf => new UntaggedFeatureViewModel(utgf)).ToArray();
        //}

        public string Title { get; }
        public UntaggedFeatureViewModel[] UntaggedFeatures { get; }
    }
}
