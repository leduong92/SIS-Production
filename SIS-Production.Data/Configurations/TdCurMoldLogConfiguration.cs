using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TdCurMoldLogConfiguration : IEntityTypeConfiguration<TdCurMoldLog>
    {
        public void Configure(EntityTypeBuilder<TdCurMoldLog> builder)
        {
            builder.ToTable("td_cur_mold_log");
            builder.HasKey(t => new { t.mold_up, t.mold_down, t.setup_date, t.setup_time, t.start_date, t.start_time, t.mold_job });

            builder.Property(x => x.mold_up).HasMaxLength(35).IsRequired();
            builder.Property(x => x.mold_down).HasMaxLength(35).IsRequired();
            builder.Property(x => x.setup_date).HasMaxLength(8);
            builder.Property(x => x.setup_time).HasMaxLength(6);
            builder.Property(x => x.setup_user).HasMaxLength(10);

            builder.Property(x => x.prepare_date).HasMaxLength(8);
            builder.Property(x => x.prepare_time).HasMaxLength(6);
            builder.Property(x => x.prepare_user).HasMaxLength(10);
            builder.Property(x => x.start_date).HasMaxLength(8);
            builder.Property(x => x.start_time).HasMaxLength(6);
            builder.Property(x => x.start_user).HasMaxLength(10);
            builder.Property(x => x.end_date).HasMaxLength(8);
            builder.Property(x => x.end_time).HasMaxLength(6);
            builder.Property(x => x.end_user).HasMaxLength(10);
            builder.Property(x => x.pro_user).HasMaxLength(10);
            builder.Property(x => x.status).HasMaxLength(2);
            builder.Property(x => x.mold_job).HasMaxLength(8);
            builder.Property(x => x.confirm_user).HasMaxLength(10);
            builder.Property(x => x.mold_rack_no).HasMaxLength(15);

            builder.Property(x => x.receive_wash_date).HasMaxLength(8);
            builder.Property(x => x.receive_wash_time).HasMaxLength(6);
            builder.Property(x => x.receive_wash_user).HasMaxLength(10);
            builder.Property(x => x.receive_wash_pro_user).HasMaxLength(10);

            builder.Property(x => x.start_wash_date).HasMaxLength(8);
            builder.Property(x => x.start_wash_time).HasMaxLength(6);
            builder.Property(x => x.start_wash_user).HasMaxLength(10);

            builder.Property(x => x.end_wash_date).HasMaxLength(8);
            builder.Property(x => x.end_wash_time).HasMaxLength(6);
            builder.Property(x => x.end_wash_user).HasMaxLength(10);

            builder.Property(x => x.old_mold_job).HasMaxLength(8);
            builder.Property(x => x.delivery_date).HasMaxLength(8);
            builder.Property(x => x.delivery_time).HasMaxLength(6);
            builder.Property(x => x.delivery_user).HasMaxLength(10);
            builder.Property(x => x.group_id).HasMaxLength(12);

            builder.Property(x => x.end_prod_date).HasMaxLength(8);
            builder.Property(x => x.end_prod_time).HasMaxLength(6);
            builder.Property(x => x.end_prod_user).HasMaxLength(10);
            builder.Property(x => x.location_cd).HasMaxLength(3);
        }
    }
}
