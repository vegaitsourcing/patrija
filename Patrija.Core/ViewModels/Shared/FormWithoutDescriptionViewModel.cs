using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrija.Common;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Shared
{
    public class FormWithoutDescriptionViewModel
    {
        public FormWithoutDescriptionViewModel(FormWithoutDescription simpleForm)
        {
            Guard.AgainstDefaultValue(simpleForm);

            Title = simpleForm.FormWithoutDescriptionTitle;
            NameFieldText = simpleForm.FormWithoutDescriptionNameFieldTitle;
            NameFieldError = simpleForm.FormWithoutDescriptionNameError;
            EmailFieldText = simpleForm.FormWithoutDescriptionEmailFieldTitle;
            EmailFieldError = simpleForm.FormWithoutDescriptionEmailError;
            CommentFieldText = simpleForm.FormWithoutDescriptionCommentFieldTitle;
            CommentFieldError = simpleForm.FormWithoutDescriptionCommentError;
            SubmitButtonText = simpleForm.FormWithoutDescriptionSubmitButtonText;
            SubmitButtonClass = Dictionaries.SupportContentBoxButtonType[simpleForm.FormWithotDescriptionSubmitButtonColor];
            SuccessMessage = simpleForm.FormWithoutDescriptionSuccessMessage;
        }

        public string Title { get; }
        public string NameFieldText { get; }
        public string NameFieldError { get; }
        public string EmailFieldText { get; }
        public string EmailFieldError { get; }
        public string CommentFieldText { get; }
        public string CommentFieldError { get; }
        public string SubmitButtonText { get; }
        public string SubmitButtonClass { get; }
        public string SuccessMessage { get; }
    }
}
