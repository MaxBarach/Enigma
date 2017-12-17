using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnigmaApp.Startup))]
namespace EnigmaApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
