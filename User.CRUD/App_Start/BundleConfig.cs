using System.Web;
using System.Web.Optimization;

namespace User.CRUD
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/iconFont.min.css",
                "~/Content/css/metro-bootstrap.min.css",
                "~/Content/css/metro-bootstrap-responsive.min.css",
                "~/Content/css/docs.css",
                "~/Scripts/prettify/prettify.css"
            ));

            BundleTable.Bundles.IgnoreList.Clear();
            bundles.Add(new ScriptBundle("~/Scripts/js").Include(
                "~/Scripts/jquery-2.1.1.js",
                "~/Scripts/jquery.widget.min.js",
                "~/Scripts/jquery.mousewheel.js",
                "~/Scripts/prettify/prettify.js",
                "~/Scripts/metro.min.js",
                "~/Scripts/docs.js"
            ));
        }
    }
}