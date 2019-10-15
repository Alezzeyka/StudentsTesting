using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentsTesting.Startup))]
namespace StudentsTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
