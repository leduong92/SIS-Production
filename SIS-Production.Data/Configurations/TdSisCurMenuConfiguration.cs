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
            builder.HasKey(x=>x.menu_id);

            builder.Property(x => x.menu_id).HasMaxLength(10);
            builder.Property(x => x.menu_name).HasMaxLength(128);
            builder.Property(x => x.id_4m).HasMaxLength(5);
        }
    }
}
