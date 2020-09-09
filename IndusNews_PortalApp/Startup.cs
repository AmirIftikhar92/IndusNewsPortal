using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IndusNews_PortalApp.Startup))]
namespace IndusNews_PortalApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
