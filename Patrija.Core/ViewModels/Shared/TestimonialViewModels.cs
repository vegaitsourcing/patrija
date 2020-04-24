using Patrija.Common;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Shared
{
    public class TestimonialViewModels
    {
        public TestimonialViewModels(TestimonialItem testimonial)
        {
            Guard.AgainstDefaultValue(testimonial);

            Text = testimonial.TestimonialItemText;
            Author = testimonial.TestimonialItemUser;
            AuthorsImage = testimonial.TestimonialItemUserImage != null ? 
                                new ImageViewModel(testimonial.TestimonialItemUserImage as Image) : 
                                default(ImageViewModel);
        }

        public string Text { get; }
        public string Author { get; }
        public ImageViewModel AuthorsImage { get; }
    }
}
