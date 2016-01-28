using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoteCaster.Startup))]
namespace VoteCaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
