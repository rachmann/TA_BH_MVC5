using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TA_BH_MVC5.Startup))]
namespace TA_BH_MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
