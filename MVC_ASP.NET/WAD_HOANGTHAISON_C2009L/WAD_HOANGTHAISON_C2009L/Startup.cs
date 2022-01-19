using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WAD_HOANGTHAISON_C2009L.Startup))]
namespace WAD_HOANGTHAISON_C2009L
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
