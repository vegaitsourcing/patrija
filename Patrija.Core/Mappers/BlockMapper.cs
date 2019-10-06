using System;
using System.Collections.Generic;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using Umbraco.Core.Models.PublishedContent;

namespace Patrija.Core.Mappers
{
    public static class BlockMapper
    {
        private static readonly Dictionary<Type, Func<IPublishedElement, object>> _contentMappers =
            new Dictionary<Type, Func<IPublishedElement, object>>()
            {
                {
                    typeof(JoinUs), el => new JoinUsViewModel((JoinUs)el)
                },
                {
                    typeof(ImageWithText), el => new ImageWithTextViewModel((ImageWithText)el)
                },
                {
                    typeof(TaggedFeature), el => new TaggedFeatureViewModel((TaggedFeature)el)
                },
                {
                    typeof(TextBlock), el => new TextBlockViewModel((TextBlock)el)
                },
                {
                    typeof(TestimonialsContainer), el => new TestimonialsContainerViewModel((TestimonialsContainer)el)
                },
                {
                    typeof(UntaggedFeature), el => new FeatruedProjectViewModel((UntaggedFeature)el)
                },
                {
                    typeof(ImageContainer), el => new ImageContainerViewModel((ImageContainer)el)
                },

            };

        public static object MapBlock(IPublishedElement blockContent)
            => _contentMappers[blockContent.GetType()](blockContent);
    }
}