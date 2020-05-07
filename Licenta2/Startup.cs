using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Licenta2.Startup))]
namespace Licenta2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
