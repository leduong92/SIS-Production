using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TdSisSectionMasterConfiguration : IEntityTypeConfiguration<TdSisSectionMaster>
    {
        public void Configure(EntityTypeBuilder<TdSisSectionMaster> builder)
        {
            builder.ToTable("td_sis_section_master");
            builder.HasKey(x=>x.section_id);

            builder.Property(x => x.section_id).HasMaxLength(12);
            builder.Property(x => x.section_name).HasMaxLength(35);
        }
    }
}
