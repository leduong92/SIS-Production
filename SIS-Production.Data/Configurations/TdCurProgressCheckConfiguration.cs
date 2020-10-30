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
            builder.HasKey(t => new { t.operation_code, t.job_order_no });

            builder.HasIndex(x => x.finished_goods_code);

            builder.Property(x => x.job_order_no).HasMaxLength(6).IsRequired();
            builder.Property(x => x.finished_goods_code).HasMaxLength(30);
            builder.Property(x => x.operation_code).HasMaxLength(6);

            builder.Property(x => x.start_date).HasMaxLength(8);
            builder.Property(x => x.start_time).HasMaxLength(6);
            builder.Property(x => x.start_user).HasMaxLength(25);
            builder.Property(x => x.end_date).HasMaxLength(8);
            builder.Property(x => x.end_time).HasMaxLength(6);
            builder.Property(x => x.end_user).HasMaxLength(25);
            builder.Property(x => x.ng_date).HasMaxLength(8);
            builder.Property(x => x.ng_time).HasMaxLength(6);
            builder.Property(x => x.ng_user).HasMaxLength(25);
            builder.Property(x => x.machine_no).HasMaxLength(10);
            builder.Property(x => x.confirm_date).HasMaxLength(8);
            builder.Property(x => x.confirm_time).HasMaxLength(6);
            builder.Property(x => x.confirm_user).HasMaxLength(25);
            builder.Property(x => x.cycle_qty).HasDefaultValue(0);
        }
    }
}
