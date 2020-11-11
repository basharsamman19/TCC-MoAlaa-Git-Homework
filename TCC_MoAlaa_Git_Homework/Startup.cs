using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TCC_MoAlaa_Git_Homework.Startup))]
namespace TCC_MoAlaa_Git_Homework
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
