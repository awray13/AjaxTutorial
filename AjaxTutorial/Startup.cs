using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxTutorial.Startup))]
namespace AjaxTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
