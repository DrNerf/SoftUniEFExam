using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoftUniEFExam.Startup))]
namespace SoftUniEFExam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
