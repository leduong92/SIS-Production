using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TdJobProductOsLogConfiguration : IEntityTypeConfiguration<TdJobProductOsLog>
    {
        public void Configure(EntityTypeBuilder<TdJobProductOsLog> builder)
        {
            builder.ToTable("td_job_product_os_log");
            builder.HasKey(t => new { t.entry_date, t.entry_time, t.entry_user, t.mold_status, t.trim_status });

            builder.Property(x => x.job_order_no).HasMaxLength(12).IsRequired();
            builder.Property(x => x.line_no).HasMaxLength(6);
            builder.Property(x => x.press_no).HasMaxLength(3);
            builder.Property(x => x.entry_date).HasMaxLength(8).IsRequired();
            builder.Property(x => x.entry_time).HasMaxLength(6).IsRequired();
            builder.Property(x => x.entry_user).HasMaxLength(25).IsRequired();
            builder.Property(x => x.start_date).HasMaxLength(8);
            builder.Property(x => x.start_time).HasMaxLength(6);
            builder.Property(x => x.start_user).HasMaxLength(25);
            builder.Property(x => x.end_date).HasMaxLength(8);
            builder.Property(x => x.end_time).HasMaxLength(6);
            builder.Property(x => x.end_user).HasMaxLength(25);
            builder.Property(x => x.reject_date).HasMaxLength(8);
            builder.Property(x => x.reject_time).HasMaxLength(6);
            builder.Property(x => x.reject_user).HasMaxLength(25);
            builder.Property(x => x.washing_date).HasMaxLength(8);
            builder.Property(x => x.washing_time).HasMaxLength(6);
            builder.Property(x => x.washing_user).HasMaxLength(25);

            builder.Property(x => x.memo).HasMaxLength(30);

            builder.Property(x => x.start_washing_date).HasMaxLength(8);
            builder.Property(x => x.start_washing_time).HasMaxLength(6);
            builder.Property(x => x.start_washing_user).HasMaxLength(25);

        }
    }
}
