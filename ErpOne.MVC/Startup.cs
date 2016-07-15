using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ErpOne.MVC.Startup))]
namespace ErpOne.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
