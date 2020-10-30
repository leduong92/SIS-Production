using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TdSisSectionLineConfiguration : IEntityTypeConfiguration<TdSisSectionLine>
    {
        public void Configure(EntityTypeBuilder<TdSisSectionLine> builder)
        {
            builder.ToTable("td_sis_section_line");
            builder.HasKey(x=>x.line_no);

            builder.Property(x => x.line_no).HasMaxLength(12);
            builder.Property(x => x.section_id).HasMaxLength(12);
        }
    }
}
