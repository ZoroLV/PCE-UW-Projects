using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebSiteP1.Areas.Identity.Data;
using WebSiteP1.Data;

[assembly: HostingStartup(typeof(WebSiteP1.Areas.Identity.IdentityHostingStartup))]
namespace WebSiteP1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebSiteDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WebSiteDBContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
              
                })
                    .AddEntityFrameworkStores<WebSiteDBContext>();
            });
        }
    }
}