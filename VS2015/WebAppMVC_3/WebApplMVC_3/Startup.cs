using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplMVC_3.Startup))]
namespace WebApplMVC_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
