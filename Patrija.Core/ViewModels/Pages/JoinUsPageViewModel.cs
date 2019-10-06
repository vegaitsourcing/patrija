using System.Linq;
using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.ContactUs;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Pages
{
    public class JoinUsPageViewModel : PageViewModel
    {
        public JoinUsPageViewModel(IPageContext<JoinUsPage> context) : base(context)
        {
            var volunteerForm = context.Page.JoinUsPageAsVolunteerForm.FirstOrDefault();
            VolunteerForm = volunteerForm != null ? new FormWithoutDescriptionViewModel(volunteerForm) : null;

            var userForm = context.Page.JoinUsPageAsVolunteerForm.FirstOrDefault();
            UserForm = volunteerForm != null ? new FormWithoutDescriptionViewModel(userForm) : null;
        }

        public FormWithoutDescriptionViewModel VolunteerForm { get; }
        public FormWithoutDescriptionViewModel UserForm { get; }
    }
}