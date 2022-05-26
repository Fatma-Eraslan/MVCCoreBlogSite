using BlogSiteEntity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteDataAccess.Mappings
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(a => a.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(a => a.LastName).HasMaxLength(50).IsRequired();
        }
    }
}
