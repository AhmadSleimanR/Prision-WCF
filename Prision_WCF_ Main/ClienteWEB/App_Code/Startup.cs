using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClienteWEB.Startup))]
namespace ClienteWEB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
