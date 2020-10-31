using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TdCurMoldWashingTimeConfiguration : IEntityTypeConfiguration<TdCurMoldWashingTime>
    {
        public void Configure(EntityTypeBuilder<TdCurMoldWashingTime> builder)
        {
            builder.ToTable("td_cur_mold_washing_time");
            builder.HasKey(x=>x.LineNo);

            builder.Property(x => x.LineNo).HasMaxLength(6);
            builder.Property(x => x.WashingTime).HasMaxLength(4);
            builder.Property(x => x.TypeName).HasMaxLength(10);

        }
    }
}
