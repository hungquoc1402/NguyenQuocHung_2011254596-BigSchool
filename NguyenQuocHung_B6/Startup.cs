using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenQuocHung_B6.Startup))]
namespace NguyenQuocHung_B6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
