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
            builder.HasKey(t => new { t.ProgressOperationSeq, t.ErrorId, t.Location, t.Department, t.ProgramId });

            builder.Property(x => x.ErrorId).HasMaxLength(10);
            builder.Property(x => x.EntryDate).HasMaxLength(8);
            builder.Property(x => x.EntryTime).HasMaxLength(6);
            builder.Property(x => x.EntryUser).HasMaxLength(10);

            builder.Property(x => x.Location).HasMaxLength(5);
            builder.Property(x => x.Status).HasMaxLength(1);
            builder.Property(x => x.Department).HasMaxLength(10);
            builder.Property(x => x.Area).HasMaxLength(10);
            builder.Property(x => x.ProgramId).HasMaxLength(10);
            builder.Property(x => x.ErrorDeptId).HasMaxLength(10);

        }
    }
}
