using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using pruebamvc_1.Areas.Identity.Data;
using pruebamvc_1.Data;

[assembly: HostingStartup(typeof(pruebamvc_1.Areas.Identity.IdentityHostingStartup))]
namespace pruebamvc_1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<pruebaDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("pruebaDbContextConnection")));

                services.AddDefaultIdentity<pruebaUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;

                })
                    .AddEntityFrameworkStores<pruebaDbContext>();
            });
        }
    }
}