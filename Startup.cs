using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Filmovi.Startup))]
namespace Filmovi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
