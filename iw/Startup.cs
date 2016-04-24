using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iw.Startup))]
namespace iw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
