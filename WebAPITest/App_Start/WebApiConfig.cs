using System.Web.Http;
using Unity.WebApi;

namespace WebAPITest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var container = UnityConfig.RegisterComponents();

            config.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}