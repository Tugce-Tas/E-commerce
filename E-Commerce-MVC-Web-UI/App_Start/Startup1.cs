using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(E_Commerce_MVC_Web_UI.App_Start.Startup1))]

namespace E_Commerce_MVC_Web_UI.App_Start
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // Uygulamanızı nasıl yapılandıracağınız hakkında daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=316888 adresini ziyaret edin

            app.UseCookieAuthentication(new CookieAuthenticationOptions() 
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Account/Login")
            }
            );
        }
    }
}
