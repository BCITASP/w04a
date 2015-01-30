using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPrimer.Startup))]
namespace MvcPrimer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
