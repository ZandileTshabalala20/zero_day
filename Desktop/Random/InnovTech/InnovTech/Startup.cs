using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InnovTech.Startup))]
namespace InnovTech
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
