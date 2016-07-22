using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AttributeR.Startup))]
namespace AttributeR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
