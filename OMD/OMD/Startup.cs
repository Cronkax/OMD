using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OMD.Startup))]
namespace OMD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
