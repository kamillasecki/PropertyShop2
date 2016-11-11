using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PropertyShop.Startup))]
namespace PropertyShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
