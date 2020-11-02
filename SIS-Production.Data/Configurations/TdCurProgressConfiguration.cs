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
            builder.HasKey(t => new { t.OperationCode, t.OperationSequence });

            builder.Property(x => x.OperationCode).HasMaxLength(6);
            builder.Property(x => x.OperationName).HasMaxLength(22);
            builder.Property(x => x.SpecialSign).HasMaxLength(1);

        }
    }
}
