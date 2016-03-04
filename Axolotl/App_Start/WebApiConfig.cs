using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Cors;
using Autofac;
using Autofac.Integration.WebApi;
using Newtonsoft.Json.Serialization;

namespace Axolotl
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyModules(typeof(WebApiConfig).Assembly);

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            // CORS
            if (ConfigurationManager.AppSettings["CORS.Enabled"] == "1")
            {
                var cors = new EnableCorsAttribute(ConfigurationManager.AppSettings["CORS.Origins"], "*", "*");
                config.EnableCors(cors);
            }

            // Formatters
            config
                .Formatters.JsonFormatter.SerializerSettings
                .ContractResolver = new CamelCasePropertyNamesContractResolver();


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
