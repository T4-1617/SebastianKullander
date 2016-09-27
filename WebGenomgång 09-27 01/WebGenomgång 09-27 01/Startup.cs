using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebGenomgång_09_27_01.Startup))]
namespace WebGenomgång_09_27_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
