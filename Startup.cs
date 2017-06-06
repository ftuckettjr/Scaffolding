using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Scaffolding8.Startup))]
namespace Scaffolding8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
