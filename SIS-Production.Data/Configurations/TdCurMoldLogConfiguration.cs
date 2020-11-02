using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TdCurMoldLogConfiguration : IEntityTypeConfiguration<TdCurMoldLog>
    {
        public void Configure(EntityTypeBuilder<TdCurMoldLog> builder)
        {
            builder.ToTable("td_cur_mold_log");
            builder.HasKey(t => new { t.MoldUp, t.MoldDown, t.SetupDate, t.SetupTime, t.StartDate, t.StartTime, t.MoldJob });

            builder.Property(x => x.MoldUp).HasMaxLength(35).IsRequired();
            builder.Property(x => x.MoldDown).HasMaxLength(35).IsRequired();
            builder.Property(x => x.SetupDate).HasMaxLength(8);
            builder.Property(x => x.SetupTime).HasMaxLength(6);
            builder.Property(x => x.SetupUser).HasMaxLength(10);

            builder.Property(x => x.PrepareDate).HasMaxLength(8);
            builder.Property(x => x.PrepareTime).HasMaxLength(6);
            builder.Property(x => x.PrepareUser).HasMaxLength(10);
            builder.Property(x => x.StartDate).HasMaxLength(8);
            builder.Property(x => x.StartTime).HasMaxLength(6);
            builder.Property(x => x.StartUser).HasMaxLength(10);
            builder.Property(x => x.EndDate).HasMaxLength(8);
            builder.Property(x => x.EndTime).HasMaxLength(6);
            builder.Property(x => x.EndUser).HasMaxLength(10);
            builder.Property(x => x.ProUser).HasMaxLength(10);
            builder.Property(x => x.Status).HasMaxLength(2);
            builder.Property(x => x.MoldJob).HasMaxLength(8);
            builder.Property(x => x.ConfirmUser).HasMaxLength(10);
            builder.Property(x => x.MoldRackNo).HasMaxLength(15);

            builder.Property(x => x.ReceiveWashDate).HasMaxLength(8);
            builder.Property(x => x.ReceiveWashTime).HasMaxLength(6);
            builder.Property(x => x.ReceiveWashUser).HasMaxLength(10);
            builder.Property(x => x.ReceiveWashProUser).HasMaxLength(10);

            builder.Property(x => x.StartWashDate).HasMaxLength(8);
            builder.Property(x => x.StartWashTime).HasMaxLength(6);
            builder.Property(x => x.StartWashUser).HasMaxLength(10);

            builder.Property(x => x.EndWashDate).HasMaxLength(8);
            builder.Property(x => x.EndWashTime).HasMaxLength(6);
            builder.Property(x => x.EndWashUser).HasMaxLength(10);

            builder.Property(x => x.OldMoldJob).HasMaxLength(8);
            builder.Property(x => x.DeliveryDate).HasMaxLength(8);
            builder.Property(x => x.DeliveryTime).HasMaxLength(6);
            builder.Property(x => x.DeliveryUser).HasMaxLength(10);
            builder.Property(x => x.GroupId).HasMaxLength(12);

            builder.Property(x => x.EndProdDate).HasMaxLength(8);
            builder.Property(x => x.EndProdTime).HasMaxLength(6);
            builder.Property(x => x.EndProdUser).HasMaxLength(10);
            builder.Property(x => x.LocationCd).HasMaxLength(3);
        }
    }
}
