using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using System.Linq;

namespace Patrija.Core.ViewModels.Pages
{
    public class JoinUsPageViewModel : PageViewModel
    {
        public JoinUsPageViewModel(IPageContext<JoinUsPage> context) : base(context)
        {
            var pageIntro = context.Page.JoinUsPageIntro.FirstOrDefault();
            PageIntro = pageIntro != null ? new PageIntroViewModel(pageIntro) : null; 

            var volunteerForm = context.Page.JoinUsPageAsVolunteerForm.FirstOrDefault();
            VolunteerForm = volunteerForm != null ? new FormWithoutDescriptionViewModel(volunteerForm) : null;

            var userForm = context.Page.JoinUsPageAsUserForm.FirstOrDefault();
            UserForm = volunteerForm != null ? new FormWithoutDescriptionViewModel(userForm) : null;
        }

        public PageIntroViewModel PageIntro { get; }
        public FormWithoutDescriptionViewModel VolunteerForm { get; }
        public FormWithoutDescriptionViewModel UserForm { get; }
    }
}