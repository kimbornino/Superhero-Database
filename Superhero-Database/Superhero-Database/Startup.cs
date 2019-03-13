using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Superhero_Database.Startup))]
namespace Superhero_Database
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
