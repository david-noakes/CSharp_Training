using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppForms1.Startup))]
namespace WebAppForms1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
