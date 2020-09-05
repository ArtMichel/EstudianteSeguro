using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admSecureStudent.Startup))]
namespace admSecureStudent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
