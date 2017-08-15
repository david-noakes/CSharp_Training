using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCModelBinding1.Startup))]
namespace MVCModelBinding1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
