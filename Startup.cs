using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesDVD.Startup))]
namespace MoviesDVD
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
