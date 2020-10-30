using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TdSis4mMasterConfiguration : IEntityTypeConfiguration<TdSis4mMaster>
    {
        public void Configure(EntityTypeBuilder<TdSis4mMaster> builder)
        {
            builder.ToTable("td_sis_4m_master");
            builder.HasKey(x=>x.id);

            builder.Property(x => x.menu_name).HasMaxLength(126);

        }
    }
}
