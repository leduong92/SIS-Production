using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TdSisCurMenuConfiguration : IEntityTypeConfiguration<TdSisCurMenu>
    {
        public void Configure(EntityTypeBuilder<TdSisCurMenu> builder)
        {
            builder.ToTable("td_sis_cur_menu");
            builder.HasKey(x=>x.MenuId);

            builder.Property(x => x.MenuId).HasMaxLength(10);
            builder.Property(x => x.MenuName).HasMaxLength(128);
            builder.Property(x => x.Id4m).HasMaxLength(5);
        }
    }
}
