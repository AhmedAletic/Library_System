using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEProjectFirst.Startup))]
namespace SEProjectFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
