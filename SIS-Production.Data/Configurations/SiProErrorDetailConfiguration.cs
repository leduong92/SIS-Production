using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;

namespace SIS_Production.Data.Configurations
{
    public class SiProErrorDetailConfiguration : IEntityTypeConfiguration<SiProErrorDetail>
    {
        public void Configure(EntityTypeBuilder<SiProErrorDetail> builder)
        {
            builder.ToTable("si_pro_error_detail");
            builder.HasKey(t => new { t.progress_operation_seq, t.error_id, t.location, t.department, t.program_id });

            builder.Property(x => x.error_id).HasMaxLength(10);
            builder.Property(x => x.entry_date).HasMaxLength(8);
            builder.Property(x => x.entry_time).HasMaxLength(6);
            builder.Property(x => x.entry_user).HasMaxLength(10);

            builder.Property(x => x.location).HasMaxLength(5);
            builder.Property(x => x.status).HasMaxLength(1);
            builder.Property(x => x.department).HasMaxLength(10);
            builder.Property(x => x.area).HasMaxLength(10);
            builder.Property(x => x.program_id).HasMaxLength(10);
            builder.Property(x => x.error_dept_id).HasMaxLength(10);

        }
    }
}
