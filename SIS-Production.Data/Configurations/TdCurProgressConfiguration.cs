using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TdCurProgressConfiguration : IEntityTypeConfiguration<TdCurProgress>
    {
        public void Configure(EntityTypeBuilder<TdCurProgress> builder)
        {
            builder.ToTable("td_cur_progress");
            builder.HasKey(t => new { t.operation_code, t.operation_sequence });

            builder.Property(x => x.operation_code).HasMaxLength(6);
            builder.Property(x => x.operation_name).HasMaxLength(22);
            builder.Property(x => x.special_sign).HasMaxLength(1);

        }
    }
}
