using System.Web.Mvc;

namespace Patrija.Core.ViewEngines
{
	public class PartialViewEngine : RazorViewEngine
	{
		public PartialViewEngine()
		{
			PartialViewLocationFormats = new[]
			{
				"~/Views/Partials/{1}/{0}.cshtml",
				"~/Views/Partials/{1}/_{0}.cshtml",
				"~/Views/Partials/Shared/_{0}.cshtml",
			};
		}
	}
}
