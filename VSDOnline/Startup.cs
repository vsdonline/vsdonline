using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSDOnline.Startup))]
namespace VSDOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
