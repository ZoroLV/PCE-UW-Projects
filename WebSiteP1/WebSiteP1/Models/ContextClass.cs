using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSiteP1.Models;

namespace WebSiteP1.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Classes> ClassList { get; set; }

        public DbSet<UserClasses> UserClassList { get; set; }

        public DbSet<UserClasses2> UserClassList2 { get; set; }
    }
}
