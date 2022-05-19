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
        public DbSet<Article> Articles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<UserDetail> UserDetails { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(@"Data Source=.; Initial Catalog=BlogDb; Integrated Security=True;");
        //    }
        //}
    }
}
