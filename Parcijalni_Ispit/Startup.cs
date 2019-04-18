using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Parcijalni_Ispit.Startup))]
namespace Parcijalni_Ispit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
