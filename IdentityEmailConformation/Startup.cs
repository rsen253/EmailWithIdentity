using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityEmailConformation.Startup))]
namespace IdentityEmailConformation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
