using System.Web.Configuration;
using System.Web.Optimization;

namespace Patrija.Core
{
	public class BundleConfig
	{
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;   //enable CDN support

            //Styles bundle
            bundles.Add(new StyleBundle("~/bundles-css/").Include("~/css/style.min.css"));

            //Scripts bundle
            bundles.Add(new ScriptBundle("~/bundles-js/").Include("~/js/global.min.js"));

            //// Scripts validation
            //bundles.Add(new ScriptBundle("~/validationScripts/").Include(
            //	"~/Scripts/jquery.validate.min.js",
            //	"~/Scripts/jquery.validate.unobtrusive.min.js"));

            // Scripts validation
            //bundles.Add(new ScriptBundle("~/validationScripts/").Include(
            //    "~/Scripts/jquery.validate.min.js",
            //    "~/Scripts/jquery.validate.unobtrusive.min.js"
            //    ));

            CompilationSection compilationSection = (CompilationSection)System.Configuration.ConfigurationManager.GetSection(@"system.web/compilation");
            BundleTable.EnableOptimizations = !compilationSection.Debug;
        }
    }
}
