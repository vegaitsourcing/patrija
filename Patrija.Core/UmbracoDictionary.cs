using Umbraco.Core.Composing;
using Umbraco.Web;

namespace Patrija.Core
{
	public static class UmbracoDictionary
	{
		private static UmbracoHelper UmbracoHelper => (UmbracoHelper) Current.Factory.GetInstance(typeof(UmbracoHelper));
	}
}
