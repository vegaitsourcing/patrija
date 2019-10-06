using Patrija.Common;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.ContactUs
{
    public class ContactMapViewModel
    {
        public ContactMapViewModel(ContactMap contactMap)
        {
            Guard.AgainstDefaultValue(contactMap, nameof(contactMap));

            Title = contactMap.ContactMapTitle;
            Text = contactMap.ContactMapText;
            LocationUrl = contactMap.ContactLocationUrl;
        }

        public string Title { get; }
        public string Text { get; }
        public string LocationUrl { get; }
    }
}