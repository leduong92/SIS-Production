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
            builder.HasKey(x=>x.Id);

            builder.Property(x => x.LineNo).HasMaxLength(10);
            builder.Property(x => x.PressNo).HasMaxLength(12);
            builder.Property(x => x.Type).HasMaxLength(5);

            builder.Property(x => x.StartDate).HasMaxLength(8);
            builder.Property(x => x.StartTime).HasMaxLength(6);
            builder.Property(x => x.StartUser).HasMaxLength(10);
            builder.Property(x => x.EndDate).HasMaxLength(8);
            builder.Property(x => x.EndTime).HasMaxLength(6);
            builder.Property(x => x.EndUser).HasMaxLength(10);
            builder.Property(x => x.ResetDate).HasMaxLength(8);
            builder.Property(x => x.ResetTime).HasMaxLength(6);
            builder.Property(x => x.ResetUser).HasMaxLength(10);
            builder.Property(x => x.Active).HasMaxLength(1);
            builder.Property(x => x.Shift).HasMaxLength(2);
            builder.Property(x => x.ErrorType).HasMaxLength(5);
        }

    }
}
