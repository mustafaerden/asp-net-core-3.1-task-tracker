using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameworkCore.TableConfigs
{
    public class TaskTableConfig : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Title).IsRequired().HasMaxLength(155);
            builder.Property(I => I.Description).HasColumnType("ntext");

            // Task has only one Urgency. Urgency has many Tasks.
            builder.HasOne(I => I.Urgency).WithMany(I => I.Tasks).HasForeignKey(I => I.UrgencyId);
        }
    }
}
