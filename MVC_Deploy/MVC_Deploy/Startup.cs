using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Deploy.Startup))]
namespace MVC_Deploy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
