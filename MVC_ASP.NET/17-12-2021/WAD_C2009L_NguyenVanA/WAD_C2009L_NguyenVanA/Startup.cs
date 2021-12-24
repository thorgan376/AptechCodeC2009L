using Microsoft.Owin;
using Owin;
using WAD_C2009L_NguyenVanA.Models;

[assembly: OwinStartupAttribute(typeof(WAD_C2009L_NguyenVanA.Startup))]
namespace WAD_C2009L_NguyenVanA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //DataContext db = new DataContext();
        }
    }
}
