using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppMvcModel1.Startup))]
namespace WebAppMvcModel1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
