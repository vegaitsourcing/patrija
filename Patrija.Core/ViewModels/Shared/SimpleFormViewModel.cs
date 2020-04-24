using System;
using Patrija.Common;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Shared
{
    public class SimpleFormViewModel
    {
        public SimpleFormViewModel(SimpleFormContent simpleForm)
        {
            Guard.AgainstDefaultValue(simpleForm);

            Title = simpleForm.SimpleFormTitle;
            Text = simpleForm.SimpleFormText.ToHtmlString();
            NameFieldText = simpleForm.SimpleFormNameFieldText;
            NameFieldError = simpleForm.SimpleFormNameError;
            EmailFieldText = simpleForm.SimpleFormEmailFieldText;
            EmailFieldError = simpleForm.SimpleFormEmailError;
            CommentFieldText = simpleForm.SimpleFormCommentFieldText;
            CommentFieldError = simpleForm.SimpleFormCommentError;
            SubmitButtonText = simpleForm.SimpleFormSubmitButtonText;
            SuccessMessage = simpleForm.SimpleFormSuccessMessage.ToHtmlString();
        }

        public SimpleFormViewModel()
        {
            NameFieldText = UmbracoDictionary.Blog.NameFieldText;
            NameFieldError = UmbracoDictionary.Blog.NameFieldError;
            EmailFieldText = UmbracoDictionary.Blog.EmailFieldText;
            EmailFieldError = UmbracoDictionary.Blog.EmailFieldError;
            CommentFieldText = UmbracoDictionary.Blog.CommentFieldText;
            CommentFieldError = UmbracoDictionary.Blog.CommentFieldError;
            SubmitButtonText = UmbracoDictionary.Blog.SubmitButton;
            SuccessMessage = UmbracoDictionary.Blog.SuccessMessage;
        }

        public string Title { get; }
        public string Text { get; }
        public string NameFieldText { get; }
        public string NameFieldError { get; }
        public string EmailFieldText { get; }
        public string EmailFieldError { get; }
        public string CommentFieldText { get; }
        public string CommentFieldError { get; }
        public string SubmitButtonText { get; }
        public string SuccessMessage { get; }
    }
}
