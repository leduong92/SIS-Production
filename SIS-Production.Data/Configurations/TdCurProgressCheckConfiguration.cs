using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TdCurProgressCheckConfiguration : IEntityTypeConfiguration<TdCurProgressCheck>
    {
        public void Configure(EntityTypeBuilder<TdCurProgressCheck> builder)
        {
            builder.ToTable("td_cur_progress_check");
            builder.HasKey(t => new { t.OperationCode, t.JobOrderNo });

            builder.HasIndex(x => x.FinishedGoodsCode);

            builder.Property(x => x.JobOrderNo).HasMaxLength(6).IsRequired();
            builder.Property(x => x.FinishedGoodsCode).HasMaxLength(30);
            builder.Property(x => x.OperationCode).HasMaxLength(6);

            builder.Property(x => x.StartDate).HasMaxLength(8);
            builder.Property(x => x.StartTime).HasMaxLength(6);
            builder.Property(x => x.StartUser).HasMaxLength(25);
            builder.Property(x => x.EndDate).HasMaxLength(8);
            builder.Property(x => x.EndTime).HasMaxLength(6);
            builder.Property(x => x.EndUser).HasMaxLength(25);
            builder.Property(x => x.NgDate).HasMaxLength(8);
            builder.Property(x => x.EndTime).HasMaxLength(6);
            builder.Property(x => x.EndUser).HasMaxLength(25);
            builder.Property(x => x.MachineNo).HasMaxLength(10);
            builder.Property(x => x.ConfirmDate).HasMaxLength(8);
            builder.Property(x => x.ConfirmTime).HasMaxLength(6);
            builder.Property(x => x.ConfirmUser).HasMaxLength(25);
            builder.Property(x => x.CycleQty).HasDefaultValue(0);
        }
    }
}
