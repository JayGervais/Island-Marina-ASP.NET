using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Island_Marina.Startup))]
namespace Island_Marina
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
