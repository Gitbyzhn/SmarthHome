using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmarthHome.Startup))]
namespace SmarthHome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
