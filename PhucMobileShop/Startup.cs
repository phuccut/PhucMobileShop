using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhucMobileShop.Startup))]
namespace PhucMobileShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
