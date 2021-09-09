using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebSiteP1.Areas.Identity.Data;

namespace WebSiteP1.Data
{
    public class WebSiteDBContext : IdentityDbContext<ApplicationUser>
    {
        public WebSiteDBContext(DbContextOptions<WebSiteDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
