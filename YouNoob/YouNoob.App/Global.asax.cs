using System.Collections.Generic;
using System.Data.Entity;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using YouNoob.Data;
using YouNoob.Data.Migrations;
using YouNoob.Infrastructure.Mappings;

namespace YouNoob.App
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<YouNoobDbContext, Configuration>());
            this.LoadAutoMapper();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void LoadAutoMapper()
        {
            var automappper = new AutoMapperConfig(new List<Assembly>() {Assembly.GetExecutingAssembly()});
            automappper.Execute();
        }
    }
}