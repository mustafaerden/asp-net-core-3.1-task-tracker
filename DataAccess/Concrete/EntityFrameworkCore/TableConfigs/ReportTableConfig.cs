using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameworkCore.TableConfigs
{
    public class ReportTableConfig : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.Property(I => I.Title).IsRequired().HasMaxLength(155);
            builder.Property(I => I.Description).HasColumnType("ntext");

            builder.HasOne(I => I.Task).WithMany(I => I.Reports).HasForeignKey(I => I.TaskId);
        }
    }
}
