using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAlmacen.Startup))]
namespace MVCAlmacen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
