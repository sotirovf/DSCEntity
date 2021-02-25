using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DSCEntity.Startup))]
namespace DSCEntity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
