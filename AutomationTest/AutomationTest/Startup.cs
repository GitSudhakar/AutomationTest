using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutomationTest.Startup))]
namespace AutomationTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
