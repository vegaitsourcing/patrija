using Patrija.Common;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.ContactUs
{
    public class ContactFormViewModel : FormWithoutDescriptionViewModel
    {
        public ContactFormViewModel(ContactForm form) : base()
        {
            Guard.AgainstDefaultValue(form);

            Address = form.Address;
            WorkingHours = form.WorkingHours;
            Title = form.ContactFormTitle;
            NameFieldText = form.ContactFormNameFieldTitle;
            NameFieldError = form.ContactFormNameError;
            EmailFieldText = form.ContactFormEmailFieldTitle;
            EmailFieldError = form.ContactFormEmailError;
            CommentFieldText = form.ContactFormCommentFieldTitle;
            CommentFieldError = form.ContactFormCommentFieldTitle;
            SubmitButtonText = form.ContactFormSubmitButtonTitle;
            SubmitButtonClass = Dictionaries.SupportContentBoxButtonType[form.ContactFormSubmitButtonColor];
            SuccessMessage = form.ContactFormSuccessMessage;
        }

        public string Address { get; }
        public string WorkingHours { get; }
    }
}
