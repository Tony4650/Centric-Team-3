using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Centric_Team_3.Startup))]
namespace Centric_Team_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
