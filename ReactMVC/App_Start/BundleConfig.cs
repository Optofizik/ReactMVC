using System.Web;
using System.Web.Optimization;

namespace ReactMVC
{
    public class BundleConfig
    {
        //Дополнительные сведения об объединении см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/react").Include(
                        "~/Scripts/react.js",
                        "~/Scripts/react-dom.js"));

            bundles.Add(new ScriptBundle("~/bundles/remarkable").Include(
                        "~/Scripts/remarkable.min.js"));
        }
    }
}
