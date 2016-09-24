using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_04.Online_Sumator.Startup))]
namespace _04.Online_Sumator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
