using System.Linq;
using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.SupportUs;
using Patrija.Core.Dtos;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Partials.Features;

namespace Patrija.Core.ViewModels.Pages
{
    public class SupportUsViewModel : PageViewModel
    {
        private const string _testimonialsContainerBackgroundImageUrl = "/assets/images/shapes/testimonials-volunteers-bg.svg";

        public SupportUsViewModel(IPageContext<SupportUs> context) : base(context)
        {
            var pageIntro = context.Page.SupportUsPageIntro;
            PageIntro = pageIntro != null ? new PageIntroViewModel(pageIntro) : null;

            var form = context.Page.SupportUsDonationForm.SingleOrDefault();
            DonationForm = form != null ? new SimpleFormViewModel(form) : null;

            var testimonials = context.Page.SupportUsTestimonials.FirstOrDefault();
            if(testimonials != null)
            {
                TestimonialsContainer = new TestimonialsContainerViewModel(testimonials, _testimonialsContainerBackgroundImageUrl);
            }

            var donations = context.Page.SupportUsDonations.FirstOrDefault();
            Donations = donations != null ? new DonationsViewModel(donations) : null;

            var frequentlyAskedQuestions = context.Page.SupportUsFaq.FirstOrDefault();
            if(frequentlyAskedQuestions != null)
            {
                FaqContainer = new FaqContainerViewModel(frequentlyAskedQuestions);
            }

            var joinUs = context.Page.SupportUsJoinUs.FirstOrDefault();
            JoinUs = joinUs != null ? new JoinUsViewModel(joinUs) : null;
        }

        public PageIntroViewModel PageIntro { get; }
        public SimpleFormViewModel DonationForm { get; } 
        public TestimonialsContainerViewModel TestimonialsContainer { get; }
        public DonationsViewModel Donations { get; }
        public FaqContainerViewModel FaqContainer { get; }
        public JoinUsViewModel JoinUs { get; }
    }
}
