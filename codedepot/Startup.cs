using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(codedepot.Startup))]
namespace codedepot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
