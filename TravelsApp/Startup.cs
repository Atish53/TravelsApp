using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelsApp.Startup))]
namespace TravelsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
