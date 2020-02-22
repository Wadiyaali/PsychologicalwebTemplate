using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectUIweb.Startup))]
namespace ProjectUIweb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
