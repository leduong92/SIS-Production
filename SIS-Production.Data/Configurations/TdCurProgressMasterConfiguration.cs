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
            builder.HasKey(t => new { t.OperationCode, t.FinishedGoodsCode });
            builder.HasIndex(x => x.FinishedGoodsCode);
            builder.Property(x => x.FinishedGoodsCode).HasMaxLength(30);
            builder.Property(x => x.OperationCode).HasMaxLength(6);
            builder.Property(x => x.OperationName).HasMaxLength(22);
            builder.Property(x => x.CheckProcessSign).HasMaxLength(6);

        }
    }
}
