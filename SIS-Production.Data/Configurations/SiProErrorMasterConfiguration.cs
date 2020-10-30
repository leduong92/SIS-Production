using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;

namespace SIS_Production.Data.Configurations
{
    public class SiProErrorMasterConfiguration : IEntityTypeConfiguration<SiProErrorMaster>
    {
        public void Configure(EntityTypeBuilder<SiProErrorMaster> builder)
        {
            builder.ToTable("si_pro_error_master");
            builder.HasKey(x=>x.error_id );

            builder.Property(x => x.error_id).HasMaxLength(10);
            builder.Property(x => x.error_name).HasMaxLength(255);
            builder.Property(x => x.error_name_jp).HasMaxLength(255);
            builder.Property(x => x.error_name_en).HasMaxLength(255);

            builder.Property(x => x.entry_date).HasMaxLength(8);
            builder.Property(x => x.entry_time).HasMaxLength(6);
            builder.Property(x => x.entry_user).HasMaxLength(10);

            builder.Property(x => x.location).HasMaxLength(5);
            builder.Property(x => x.status).HasMaxLength(1);

        }
    }
}
