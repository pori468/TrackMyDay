using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrackMyDay.Startup))]
namespace TrackMyDay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
