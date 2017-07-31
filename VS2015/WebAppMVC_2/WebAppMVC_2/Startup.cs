using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppMVC_2.Startup))]
namespace WebAppMVC_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
