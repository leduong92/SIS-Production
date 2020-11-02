using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TdJobPrmoldOsConfiguration : IEntityTypeConfiguration<TdJobPrmoldOs>
    {
        public void Configure(EntityTypeBuilder<TdJobPrmoldOs> builder)
        {
            builder.ToTable("td_job_prmold_os");
            builder.HasKey(x => x.JobOrderNo);

            builder.HasIndex(x => x.JobOrderNo);

            builder.Property(x => x.JobOrderNo).HasMaxLength(12).IsRequired();
            builder.Property(x => x.LineNo).HasMaxLength(6);
            builder.Property(x => x.PressNo).HasMaxLength(3);
            builder.Property(x => x.PressName).HasMaxLength(20);

            builder.Property(x => x.Status).HasDefaultValue(0);

            builder.Property(x => x.StartDate).HasMaxLength(8);
            builder.Property(x => x.StartTime).HasMaxLength(6);
            builder.Property(x => x.StartUser).HasMaxLength(25);
            builder.Property(x => x.EndDate).HasMaxLength(8);
            builder.Property(x => x.EndTime).HasMaxLength(6);
            builder.Property(x => x.EndUser).HasMaxLength(25);
            builder.Property(x => x.RejectDate).HasMaxLength(8);
            builder.Property(x => x.RejectTime).HasMaxLength(6);
            builder.Property(x => x.RejectUser).HasMaxLength(25);
            builder.Property(x => x.WashingDate).HasMaxLength(8);
            builder.Property(x => x.WashingTime).HasMaxLength(6);
            builder.Property(x => x.WashingUser).HasMaxLength(25);

            builder.Property(x => x.WashingStatus).HasDefaultValue(0);

            builder.Property(x => x.StartWashingDate).HasMaxLength(8);
            builder.Property(x => x.StartWashingTime).HasMaxLength(6);
            builder.Property(x => x.StartWashingUser).HasMaxLength(25);

            builder.Property(x => x.StartDate01).HasMaxLength(8);
            builder.Property(x => x.StartTime01).HasMaxLength(6);
            builder.Property(x => x.StartUser01).HasMaxLength(10);

        }
    }
}
