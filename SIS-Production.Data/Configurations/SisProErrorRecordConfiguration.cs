using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class SisProErrorRecordConfiguration : IEntityTypeConfiguration<SisProErrorRecord>
    {
        public void Configure(EntityTypeBuilder<SisProErrorRecord> builder)
        {
            builder.ToTable("sis_pro_error_record");
            builder.HasKey(x => x.JobOrderNo);
            builder.HasKey(x => x.OperationNumber);
            builder.HasKey(x => x.ProgressOperationCode);
            builder.HasKey(x => x.ProgressOperationSeq);
            builder.HasKey(x => x.ErrorId);

            builder.Property(x => x.JobOrderNo).HasMaxLength(12).IsRequired();
            builder.Property(x => x.OperationNumber).IsRequired();
            builder.Property(x => x.FinishedGoodsCode).HasMaxLength(20);
            builder.Property(x => x.LotNo).HasMaxLength(10);

            builder.Property(x => x.LineNo).HasMaxLength(9);
            builder.Property(x => x.RubberName).HasMaxLength(8);
            builder.Property(x => x.JobStartDate).HasMaxLength(10);
            builder.Property(x => x.JobOrderNo).HasMaxLength(10);
            builder.Property(x => x.OperationStartDate).HasMaxLength(10);
            builder.Property(x => x.OperationEndDate).HasMaxLength(10);
            builder.Property(x => x.MachineNo).HasMaxLength(10);
            builder.Property(x => x.ProgressOperationCode).HasMaxLength(6);
            builder.Property(x => x.ProgressOperationName).HasMaxLength(22);
            builder.Property(x => x.ErrorId).HasMaxLength(10).IsRequired();
            builder.Property(x => x.ErrorName).HasMaxLength(255);
            builder.Property(x => x.ErrorNameJp).HasMaxLength(255);

            builder.Property(x => x.Notes).HasMaxLength(255);

            builder.Property(x => x.EntryDate).HasMaxLength(10);
            builder.Property(x => x.EntryTime).HasMaxLength(6);
            builder.Property(x => x.EntryUser).HasMaxLength(10);

            builder.Property(x => x.UpdateDate).HasMaxLength(10);
            builder.Property(x => x.UpdateTime).HasMaxLength(6);
            builder.Property(x => x.UpdateUser).HasMaxLength(10);

            builder.Property(x => x.Status).HasMaxLength(1);

            builder.Property(x => x.ErrorNameEn).HasMaxLength(255);
            builder.Property(x => x.CuringDate).HasMaxLength(10);
            builder.Property(x => x.Department).HasMaxLength(10);
            builder.Property(x => x.Area).HasMaxLength(10);
            builder.Property(x => x.ProgramId).HasMaxLength(10);
            builder.Property(x => x.PressNo).HasMaxLength(5);
        }
    }
}
