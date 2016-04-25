using System.Web;
using System.Web.Optimization;

namespace VSDOnline
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
          "~/Scripts/bootstrap.js",
          "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/font-awesome.css",
                      "~/Content/social-buttons.css",
                      "~/Content/site.css",
                      "~/Content/spinrays.css",
                      "~/Content/adtext-rotator.css"));

            bundles.Add(new ScriptBundle("~/bundles/youtube", "https://www.youtube.com/iframe_api").Include(
                "~/Scripts/youtubeAudio.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/site").Include(
                "~/Scripts/site.js",
                "~/Scripts/google-analytics.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/histats").Include(
                "~/Scripts/histats-counter.js"));
        }
    }
}
