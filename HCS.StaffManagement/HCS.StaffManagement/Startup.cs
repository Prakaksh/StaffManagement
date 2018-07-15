using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HCS.StaffManagement.Startup))]
namespace HCS.StaffManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
