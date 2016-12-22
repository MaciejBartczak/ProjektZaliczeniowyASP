using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjektZaliczeniowyASP.Startup))]
namespace ProjektZaliczeniowyASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
