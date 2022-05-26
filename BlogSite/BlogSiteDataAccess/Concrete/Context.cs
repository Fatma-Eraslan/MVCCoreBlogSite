using BlogSiteCore.Entities.Enums;
using BlogSiteEntity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteDataAccess.Concrete
{
  public  class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Article> Articles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<UserDetail> UserDetails { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=BlogDb;Integrated Security=true;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { Id = 1, FirstName = "Admin", LastName = "Admin", EMail = "admin@mail.com", Password = "1234" });
            modelBuilder.Entity<UserDetail>().HasData(new UserDetail { Id = 1, UserID = 1, IsActive = true, UserRole = UserRole.Admin, Job = "Admin", Gender = true, Username = "Admin", Explanation = "Admin" });
        }

    }
}
