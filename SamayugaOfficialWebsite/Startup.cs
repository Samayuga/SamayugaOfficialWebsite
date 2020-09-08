using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OfficialSite.Startup))]
namespace OfficialSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
