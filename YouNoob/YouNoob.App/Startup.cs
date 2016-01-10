using Microsoft.Owin;
using Owin;
using YouNoob.App;

[assembly: OwinStartup(typeof (Startup))]

namespace YouNoob.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}