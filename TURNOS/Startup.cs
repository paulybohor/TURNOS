using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TURNOS.Startup))]
namespace TURNOS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
