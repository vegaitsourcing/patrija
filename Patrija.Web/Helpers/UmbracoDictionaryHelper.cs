using Umbraco.Core.Composing;
using Umbraco.Web;

namespace Patrija.Web.Helpers
{
    public class UmbracoDictionaryHelper
    {
        private static UmbracoHelper UmbracoHelper => (UmbracoHelper)Current.Factory.GetInstance(typeof(UmbracoHelper));

        public static class ScreenReaders
        {
            public static string BtnClose => UmbracoHelper.GetDictionaryValue("BtnClose");
        }

    }
}