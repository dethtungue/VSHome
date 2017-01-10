using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeTestMVC1.Startup))]
namespace HomeTestMVC1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
