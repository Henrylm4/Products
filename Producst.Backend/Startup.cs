using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Producst.Backend.Startup))]
namespace Producst.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
