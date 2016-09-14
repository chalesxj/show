using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(git_test.Startup))]
namespace git_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
