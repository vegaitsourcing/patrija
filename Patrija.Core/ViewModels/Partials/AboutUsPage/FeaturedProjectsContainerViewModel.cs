using System;
using System.Linq;
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
            featruedProjectViewModels = projectsContainer.AboutUsUntaggedFeaturesContainer.Select(utgf => new FeatruedProjectViewModel(utgf)).ToArray();
        }

        public string Title { get; }
        public FeatruedProjectViewModel[] featruedProjectViewModels { get; }
    }
}
