using Patrija.Common;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.JoinUs
{
    public class JoinUsFormViewModel : FormWithoutDescriptionViewModel
    {
        public JoinUsFormViewModel(JoinUsForm form) : base()
        {
            Guard.AgainstDefaultValue(form);

            Image = form.Image != null ? new ImageViewModel(form.Image as Image) : null;
            IsVolunteer = form.IsVolunteerForm;
            PopupButtonText = form.PopupButtonText;
            NameFieldText = form.FormWithoutDescriptionNameFieldTitle;
            NameFieldError = form.FormWithoutDescriptionNameError;
            EmailFieldText = form.FormWithoutDescriptionEmailFieldTitle;
            EmailFieldError = form.FormWithoutDescriptionEmailError;
            CommentFieldText = form.FormWithoutDescriptionCommentFieldTitle;
            CommentFieldError = form.FormWithoutDescriptionCommentError;
            SubmitButtonText = form.FormWithoutDescriptionSubmitButtonText;
            SubmitButtonClass = Dictionaries.SupportContentBoxButtonType[form.FormWithotDescriptionSubmitButtonColor];
            SuccessMessage = form.FormWithoutDescriptionSuccessMessage;
        }

        public ImageViewModel Image { get; }
        public bool IsVolunteer { get; }
        public string PopupButtonText { get; }
    }
}
