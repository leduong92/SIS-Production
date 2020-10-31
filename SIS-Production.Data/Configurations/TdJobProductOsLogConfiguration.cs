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
            builder.HasKey(t => new { t.EntryDate, t.EntryTime, t.EntryUser, t.MoldStatus, t.TrimStatus });

            builder.Property(x => x.JobOrderNo).HasMaxLength(12).IsRequired();
            builder.Property(x => x.LineNo).HasMaxLength(6);
            builder.Property(x => x.PressNo).HasMaxLength(3);
            builder.Property(x => x.EntryDate).HasMaxLength(8).IsRequired();
            builder.Property(x => x.EntryTime).HasMaxLength(6).IsRequired();
            builder.Property(x => x.EntryUser).HasMaxLength(25).IsRequired();
            builder.Property(x => x.StartDate).HasMaxLength(8);
            builder.Property(x => x.StartTime).HasMaxLength(6);
            builder.Property(x => x.StartUser).HasMaxLength(25);
            builder.Property(x => x.EntryDate).HasMaxLength(8);
            builder.Property(x => x.EntryTime).HasMaxLength(6);
            builder.Property(x => x.EntryUser).HasMaxLength(25);
            builder.Property(x => x.RejectDate).HasMaxLength(8);
            builder.Property(x => x.RejectTime).HasMaxLength(6);
            builder.Property(x => x.RejectUser).HasMaxLength(25);
            builder.Property(x => x.WashingDate).HasMaxLength(8);
            builder.Property(x => x.WashingTime).HasMaxLength(6);
            builder.Property(x => x.WashingUser).HasMaxLength(25);

            builder.Property(x => x.Memo).HasMaxLength(30);

            builder.Property(x => x.StartWashingDate).HasMaxLength(8);
            builder.Property(x => x.StartWashingTime).HasMaxLength(6);
            builder.Property(x => x.StartWashingTime).HasMaxLength(25);

        }
    }
}
