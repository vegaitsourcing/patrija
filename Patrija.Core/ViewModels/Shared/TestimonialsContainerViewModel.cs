using Patrija.Common;
using Patrija.Models.Generated;
using System.Linq;

namespace Patrija.Core.ViewModels.Shared
{
    public class TestimonialsContainerViewModel
    {
        public TestimonialsContainerViewModel(TestimonialsContainer testimonialsContainer, string backgroundImageUrl)
        {
            Guard.AgainstDefaultValue(testimonialsContainer);
            Guard.AgainstDefaultValue(testimonialsContainer.TestimonialsContainerItems);

            Title = testimonialsContainer.TestimonialsContainerTitle;
            Testimonials = testimonialsContainer.TestimonialsContainerItems.Select(t => new TestimonialViewModels(t)).ToArray();
            BackgroundImage = new ImageViewModel(backgroundImageUrl);
        }

        public string Title { get; }
        public ImageViewModel BackgroundImage { get; }
        public TestimonialViewModels[] Testimonials { get; }
    }
}
