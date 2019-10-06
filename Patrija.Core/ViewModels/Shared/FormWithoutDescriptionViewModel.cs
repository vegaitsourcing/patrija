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
        public FormWithoutDescriptionViewModel() { }

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

        public string Title { get; set; }
        public string NameFieldText { get; set; }
        public string NameFieldError { get; set; }
        public string EmailFieldText { get; set; }
        public string EmailFieldError { get; set; }
        public string CommentFieldText { get; set; }
        public string CommentFieldError { get; set; }
        public string SubmitButtonText { get; set; }
        public string SubmitButtonClass { get; set; }
        public string SuccessMessage { get; set; }
    }
}
