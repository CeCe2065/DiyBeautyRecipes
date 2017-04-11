using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiyBeautyRecipes.Startup))]
namespace DiyBeautyRecipes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
