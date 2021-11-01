using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Brokerage_Platform.Startup))]
namespace Brokerage_Platform
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
