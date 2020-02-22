using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReservationWebApp.Startup))]
namespace ReservationWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
