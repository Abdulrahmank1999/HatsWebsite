using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HatsApi.Modules
{
    public class HatDbContext: DbContext
    {
        public HatDbContext(DbContextOptions<HatDbContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<UserHat>()
        //.HasKey(p => new { p.HatId, p.UserId });
        //}

        public DbSet<Admin> Admins { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Hat> Hats { get; set; }

    }
}
