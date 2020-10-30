using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TdSisErrorMenuConfiguration : IEntityTypeConfiguration<TdSisErrorMenu>
    {
        public void Configure(EntityTypeBuilder<TdSisErrorMenu> builder)
        {
            builder.ToTable("td_sis_error_menu");
            builder.HasKey(x=>x.error_id);

            builder.Property(x => x.error_id).HasMaxLength(5);
            builder.Property(x => x.error_menu).HasMaxLength(128);
            builder.Property(x => x.type).HasMaxLength(5);
        }
    }
}
