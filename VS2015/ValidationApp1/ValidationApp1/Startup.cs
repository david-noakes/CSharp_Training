using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ValidationApp1.Startup))]
namespace ValidationApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
