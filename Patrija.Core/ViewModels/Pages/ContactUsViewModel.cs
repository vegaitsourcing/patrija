using System.Linq;
using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Partials.ContactUs;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Pages
{
    public class ContactUsViewModel : PageViewModel
    {
        public ContactUsViewModel(IPageContext<ContactUs> context) : base(context)
        {
            var mapInfo = context.Page.ContactUsMapInfo.FirstOrDefault();
            MapInfo = mapInfo != null ?  new ContactMapViewModel(mapInfo) : null;

            var form = context.Page.ContactUsForm.FirstOrDefault();
            Form = form != null ? new ContactFormViewModel(form) : null;
        }

        public ContactMapViewModel MapInfo { get; }
        public ContactFormViewModel Form { get; }
    }
}