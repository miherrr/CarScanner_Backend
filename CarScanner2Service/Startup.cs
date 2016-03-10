using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CarScanner2Service.Startup))]

namespace CarScanner2Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}