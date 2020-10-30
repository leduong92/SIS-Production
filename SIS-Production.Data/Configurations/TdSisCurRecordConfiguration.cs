using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TdSisCurRecordConfiguration : IEntityTypeConfiguration<TdSisCurRecord>
    {
        public void Configure(EntityTypeBuilder<TdSisCurRecord> builder)
        {
            builder.ToTable("td_sis_cur_record");
            builder.HasKey(x=>x.id);

            builder.Property(x => x.line_no).HasMaxLength(10);
            builder.Property(x => x.press_no).HasMaxLength(12);
            builder.Property(x => x.type).HasMaxLength(5);

            builder.Property(x => x.start_date).HasMaxLength(8);
            builder.Property(x => x.start_time).HasMaxLength(6);
            builder.Property(x => x.start_user).HasMaxLength(10);
            builder.Property(x => x.end_date).HasMaxLength(8);
            builder.Property(x => x.end_time).HasMaxLength(6);
            builder.Property(x => x.end_user).HasMaxLength(10);
            builder.Property(x => x.reset_date).HasMaxLength(8);
            builder.Property(x => x.reset_time).HasMaxLength(6);
            builder.Property(x => x.reset_user).HasMaxLength(10);
            builder.Property(x => x.active).HasMaxLength(1);
            builder.Property(x => x.shift).HasMaxLength(2);
            builder.Property(x => x.error_type).HasMaxLength(5);
        }

    }
}
