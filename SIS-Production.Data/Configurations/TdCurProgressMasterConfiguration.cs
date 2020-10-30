using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TdCurProgressMasterConfiguration : IEntityTypeConfiguration<TdCurProgressMaster>
    {
        public void Configure(EntityTypeBuilder<TdCurProgressMaster> builder)
        {
            builder.ToTable("td_cur_progress_master");
            builder.HasKey(t => new { t.operation_code, t.finished_goods_code });
            builder.HasIndex(x => x.finished_goods_code);
            builder.Property(x => x.finished_goods_code).HasMaxLength(30);
            builder.Property(x => x.operation_code).HasMaxLength(6);
            builder.Property(x => x.operation_name).HasMaxLength(22);
            builder.Property(x => x.check_process_sign).HasMaxLength(6);

        }
    }
}
