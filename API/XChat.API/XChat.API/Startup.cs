using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(XChat.API.Startup))]

namespace XChat.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
