using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(C2C.Startup))]
namespace C2C
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
