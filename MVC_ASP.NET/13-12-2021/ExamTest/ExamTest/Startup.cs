using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamTest.Startup))]
namespace ExamTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
