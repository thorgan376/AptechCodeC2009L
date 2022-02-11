using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WAD_C2009L_HoangThaiSon1.Startup))]
namespace WAD_C2009L_HoangThaiSon1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
