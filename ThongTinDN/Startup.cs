using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThongTinDN.Startup))]
namespace ThongTinDN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
