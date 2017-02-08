using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoReact.Startup))]
namespace DemoReact
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
