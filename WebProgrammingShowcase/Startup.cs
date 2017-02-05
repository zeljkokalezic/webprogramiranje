using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebProgrammingShowcase.Startup))]
namespace WebProgrammingShowcase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
