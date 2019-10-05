using System;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Shared
{
    public class SimpleFormViewModel
    {
        public SimpleFormViewModel(SimpleFormContent simpleForm)
        {
            if (simpleForm == null) throw new ArgumentNullException(nameof(simpleForm));

            Title = simpleForm.SimpleFormTitle;
            Text = simpleForm.SimpleFormText.ToHtmlString();
            NameFieldText = simpleForm.SimpleFormNameFieldText;
            NameFieldError = simpleForm.SimpleFormNameError;
            EmailFieldText = simpleForm.SimpleFormEmailFieldText;
            EmailFieldError = simpleForm.SimpleFormEmailError;
            SubmitButtonText = simpleForm.SimpleFormSubmitButtonText;
            SuccessMessage = simpleForm.SimpleFormSuccessMessage.ToHtmlString();
        }

        public string Title { get; }
        public string Text { get; }
        public string NameFieldText { get; }
        public string NameFieldError { get; }
        public string EmailFieldText { get; }
        public string EmailFieldError { get; }
        public string SubmitButtonText { get; }
        public string SuccessMessage { get; }
    }
}
