using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameworkCore.TableConfigs
{
    public class UrgencyTableConfig : IEntityTypeConfiguration<Urgency>
    {
        public void Configure(EntityTypeBuilder<Urgency> builder)
        {
            builder.Property(I => I.Title).IsRequired().HasMaxLength(100);

            // burdan bu sekil de yapabilirdik. Task dan task in acisindan relation i belirtsek te olur. iki taraftan belirtmeye gerek yok.
            //builder.HasMany(I => I.Tasks).WithOne(I => I.Urgency).HasForeignKey(I => I.UrgencyId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
