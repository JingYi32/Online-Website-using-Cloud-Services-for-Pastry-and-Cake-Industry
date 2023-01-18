using System;
using DDAC_Assignment.Areas.Identity.Data;
using DDAC_Assignment.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DDAC_Assignment.Areas.Identity.IdentityHostingStartup))]
namespace DDAC_Assignment.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DDAC_AssignmentContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DDAC_AssignmentContextConnection")));

                services.AddDefaultIdentity<RT_Pastry_User>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<DDAC_AssignmentContext>();
            });
        }
    }
}