using Patrija.Common;
using Patrija.Models.Generated;
using System.Linq;

namespace Patrija.Core.ViewModels.Shared
{
    public class TestimonialsContainerViewModel
    {
        public TestimonialsContainerViewModel(TestimonialsContainer testimonialsContainer)
        {
            Guard.AgainstDefaultValue(testimonialsContainer);
            Guard.AgainstDefaultValue(testimonialsContainer.TestimonialContainerTestimonial);

            Title = testimonialsContainer.TestimonialContainerTitle;
            Testimonials = testimonialsContainer.TestimonialContainerTestimonial.Select(t => new TestimonialViewModels(t)).ToArray();
        }

        public string Title { get; }
        public TestimonialViewModels[] Testimonials { get; }
    }
}
