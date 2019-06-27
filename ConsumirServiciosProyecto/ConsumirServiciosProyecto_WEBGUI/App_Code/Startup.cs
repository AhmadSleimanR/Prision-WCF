using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsumirServiciosProyecto.Startup))]
namespace ConsumirServiciosProyecto
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
