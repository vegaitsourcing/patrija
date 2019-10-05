using System.Linq;
using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Pages
{
    public class SupportUsViewModel : PageViewModel
    {
        public SupportUsViewModel(IPageContext<SupportUs> context) : base(context)
        {
            var form = context.Page.SupportUsDonationForm.SingleOrDefault();
            DonationForm = form != null ? new SimpleFormViewModel(form) : null;

            var testimonials = context.Page.SupportUsTestimonials.FirstOrDefault();
            if(testimonials != null)
            {
                TestimonialsContainer = new TestimonialsContainerViewModel(testimonials);
            }
        }

        public SimpleFormViewModel DonationForm { get; } 
        public TestimonialsContainerViewModel TestimonialsContainer { get; }
    }
}
