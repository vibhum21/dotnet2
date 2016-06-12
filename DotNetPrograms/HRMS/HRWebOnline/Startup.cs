using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HRWebOnline.Startup))]
namespace HRWebOnline
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
