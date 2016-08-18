using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FabrikamPortal.Startup))]
namespace FabrikamPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
