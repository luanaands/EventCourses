using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventCourses.Startup))]
namespace EventCourses
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
