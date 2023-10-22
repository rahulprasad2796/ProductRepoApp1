using AutoMapper;
using ProductRepoApp.App_Start;
using System.Web.Http;

namespace ProductRepoApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            UnityConfig.RegisterComponents();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());
        }
    }
}
