using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_15.Fruit_Web_Game.Startup))]
namespace _15.Fruit_Web_Game
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
