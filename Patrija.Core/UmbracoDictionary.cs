using Umbraco.Core.Composing;
using Umbraco.Web;

namespace Patrija.Core
{
	public static class UmbracoDictionary
	{
		private static UmbracoHelper UmbracoHelper => (UmbracoHelper) Current.Factory.GetInstance(typeof(UmbracoHelper));

        public static class ScreenReaders
        {
            public static string BtnClose => UmbracoHelper.GetDictionaryValue("ScreenReaders.BtnClose");
        }

        public static class ContactUs
        {
            public static string WorkingHours => UmbracoHelper.GetDictionaryValue("ContactUs.WorkingHours");
            public static string Address => UmbracoHelper.GetDictionaryValue("ContactUs.Address");
        }

        public static class News
        {
            public static string ShareTitle => UmbracoHelper.GetDictionaryValue("News.ShareTitle");
            public static string LoadMoreButton => UmbracoHelper.GetDictionaryValue("News.LoadMoreButton");
        }

        public static class Common
        {
            public static string ReadMore => UmbracoHelper.GetDictionaryValue("Common.ReadMore");
        }

        public static class Blog
        {
            public static string CommentsTitle => UmbracoHelper.GetDictionaryValue("Blog.CommentsTitle");
            public static string CommentFieldError => UmbracoHelper.GetDictionaryValue("Blog.Form.CommentFieldError");
            public static string CommentFieldText => UmbracoHelper.GetDictionaryValue("Blog.Form.CommentFieldText");
            public static string EmailFieldError => UmbracoHelper.GetDictionaryValue("Blog.Form.EmailFieldError");
            public static string EmailFieldText => UmbracoHelper.GetDictionaryValue("Blog.Form.EmailFieldText");
            public static string NameFieldError => UmbracoHelper.GetDictionaryValue("Blog.Form.NameFieldError");
            public static string NameFieldText => UmbracoHelper.GetDictionaryValue("Blog.Form.NameFieldText");
            public static string SubmitButton => UmbracoHelper.GetDictionaryValue("Blog.Form.SubmitButton");
            public static string SuccessMessage => UmbracoHelper.GetDictionaryValue("Blog.Form.SuccessMessage");
        }

        public static class AboutUs
        {
            public static string CurrentProjects => UmbracoHelper.GetDictionaryValue("AboutUs.CurrentProjects");
            public static string FinishedProjects => UmbracoHelper.GetDictionaryValue("AboutUs.FinishedProjects");
        }
    }
}
