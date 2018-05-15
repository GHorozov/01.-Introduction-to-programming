using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_08.WebSumator.Startup))]
namespace _08.WebSumator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
