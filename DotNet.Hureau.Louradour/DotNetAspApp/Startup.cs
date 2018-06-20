using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetAspApp.Startup))]
namespace DotNetAspApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
