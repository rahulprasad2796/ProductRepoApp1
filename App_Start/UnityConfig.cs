using ProductRepoApp.DAL;
using System.Web.Http;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;

namespace ProductRepoApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IProductRepository, ProductRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}