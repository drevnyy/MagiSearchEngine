using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MagiSearchEngine.Startup))]
namespace MagiSearchEngine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
