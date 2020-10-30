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
            builder.HasKey(x => x.job_order_no);

            builder.HasIndex(x => x.job_order_no);

            builder.Property(x => x.job_order_no).HasMaxLength(12).IsRequired();
            builder.Property(x => x.line_no).HasMaxLength(6);
            builder.Property(x => x.press_no).HasMaxLength(3);
            builder.Property(x => x.press_name).HasMaxLength(20);

            builder.Property(x => x.status).HasDefaultValue(0);

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

            builder.Property(x => x.washing_status).HasDefaultValue(0);

            builder.Property(x => x.start_washing_date).HasMaxLength(8);
            builder.Property(x => x.start_washing_time).HasMaxLength(6);
            builder.Property(x => x.start_washing_user).HasMaxLength(25);

            builder.Property(x => x.start_date_01).HasMaxLength(8);
            builder.Property(x => x.start_time_01).HasMaxLength(6);
            builder.Property(x => x.start_user_01).HasMaxLength(10);

        }
    }
}
