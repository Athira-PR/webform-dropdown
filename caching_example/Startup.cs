using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(caching_example.Startup))]
namespace caching_example
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
