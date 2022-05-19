using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Entites
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public DbSet<Articles> Articles { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<Topics> Topics { get; set; }

        public DbSet<UserDetail> UserDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().Property(a => a.FirstName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Users>().Property(a => a.LastName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Users>().Property(a => a.EMail).HasMaxLength(50).IsRequired();
            
            modelBuilder.Entity<Articles>().Property(a => a.Title).HasMaxLength(30).IsRequired();

        }
    } 
}
