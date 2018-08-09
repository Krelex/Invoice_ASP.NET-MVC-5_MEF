using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Enterwell_Fakture.Startup))]
namespace Enterwell_Fakture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
