using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameworkCore.TableConfigs
{
    public class AppUserTableConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(I => I.Name).IsRequired().HasMaxLength(100);

            // user birden fazla tasks i var, task in bir user i var;
            // user silinir ise task in user i null olarak atansin. Default unda direk task i da siler.
            builder.HasMany(I => I.Tasks).WithOne(I => I.AppUser).HasForeignKey(I => I.AppUserId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
