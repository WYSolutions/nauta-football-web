using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NautaFootball.Startup))]
namespace NautaFootball
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
