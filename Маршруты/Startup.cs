using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Маршруты.Startup))]
namespace Маршруты
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
