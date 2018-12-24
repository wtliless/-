using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplicationForMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //var test1 = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;

            //var test = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;
            System.Collections.Generic.List
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
