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
    }
}
