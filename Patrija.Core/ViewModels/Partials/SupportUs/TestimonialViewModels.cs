using Patrija.Common;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.SupportUs
{
    public class TestimonialViewModels
    {
        public TestimonialViewModels(TestimonialItem testimonial)
        {
            Guard.AgainstDefaultValue(testimonial);

            Text = testimonial.TestimonialItemText;
            User = testimonial.TestimonialItemUser;
            UserImage = new ImageViewModel(testimonial.TestimonialItemUserImage as Image);
        }

        public string Text { get; }
        public string User { get; }
        public ImageViewModel UserImage { get; }
    }
}
