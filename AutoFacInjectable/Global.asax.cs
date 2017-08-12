using AutoFacInjectable.Infrastructure;
using System.Web.Http;

namespace AutoFacInjectable
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutofacDependecyBuilder.DependencyBuilder();
        }
    }
}
