using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsumeSAML2.Startup))]
namespace ConsumeSAML2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
