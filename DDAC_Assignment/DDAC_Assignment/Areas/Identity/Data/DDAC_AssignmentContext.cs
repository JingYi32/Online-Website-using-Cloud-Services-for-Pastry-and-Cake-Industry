using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDAC_Assignment.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DDAC_Assignment.Data
{
    public class DDAC_AssignmentContext : IdentityDbContext<RT_Pastry_User>
    {
        public DDAC_AssignmentContext(DbContextOptions<DDAC_AssignmentContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
