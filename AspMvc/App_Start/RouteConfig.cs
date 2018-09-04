using System.Web.Mvc;
using System.Web.Routing;

namespace AspMvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "GetPhotoLink",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "GetPhotoLink", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
