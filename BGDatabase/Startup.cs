using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BGDatabase.Startup))]
namespace BGDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
