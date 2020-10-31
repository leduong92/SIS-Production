using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TrCurJobNbcsConfiguration : IEntityTypeConfiguration<TrCurJobNbcs>
    {
        public void Configure(EntityTypeBuilder<TrCurJobNbcs> builder)
        {
            builder.ToTable("tr_cur_job_nbcs");
            builder.HasKey(x => x.JobOrderNo);

            builder.HasIndex(x => x.MpCode);
            builder.HasIndex(x => x.EntryDate);
            builder.HasIndex(x => x.FinishedGoodsCode);
            builder.HasIndex(x => x.EntryNo);
            builder.HasIndex(x => x.LineNo);

            builder.Property(x => x.RecordStatus).HasMaxLength(1);
            builder.Property(x => x.EntryTerminalId).HasMaxLength(10);
            builder.Property(x => x.ProgramId).HasMaxLength(10);
            builder.Property(x => x.UpdateUserCode).HasMaxLength(10);
            builder.Property(x => x.CompanyCode).HasMaxLength(5);
            builder.Property(x => x.PlantCode).HasMaxLength(4);
            builder.Property(x => x.JobOrderNo).HasMaxLength(12);
            builder.Property(x => x.DataTransferCompleteSign).HasMaxLength(1);
            builder.Property(x => x.ErrSign).HasMaxLength(5);
            builder.Property(x => x.ParentJobOrderNo).HasMaxLength(12);
            builder.Property(x => x.DivideSign).HasMaxLength(1);
            builder.Property(x => x.ManufacturedCuring).HasMaxLength(2);
            builder.Property(x => x.ListTypeRubber).HasMaxLength(2);
            builder.Property(x => x.ListTypeParts).HasMaxLength(2);
            builder.Property(x => x.PurchaseOrder).HasMaxLength(2);
            builder.Property(x => x.ProcessSign7).HasMaxLength(1);
            builder.Property(x => x.ProcessSign8).HasMaxLength(1);
            builder.Property(x => x.ProcessSign9).HasMaxLength(1);
            builder.Property(x => x.ProcessSign10).HasMaxLength(1);
            builder.Property(x => x.UrgentScheduleSign).HasMaxLength(1);
            builder.Property(x => x.MachineSetUpSign).HasMaxLength(1);
            builder.Property(x => x.FinalSign).HasMaxLength(1);
            builder.Property(x => x.JisSign).HasMaxLength(1);
            builder.Property(x => x.SetItemSign).HasMaxLength(1);
            builder.Property(x => x.FinishedGoodsCode).HasMaxLength(20);
            builder.Property(x => x.CustomerCode).HasMaxLength(5);
            builder.Property(x => x.LimitationItemSign).HasMaxLength(1);

            builder.Property(x => x.MpCode).HasMaxLength(1);
            builder.Property(x => x.EnterpriseCode).HasMaxLength(1);
            builder.Property(x => x.LineGroup).HasMaxLength(6);
            builder.Property(x => x.LineNo).HasMaxLength(6);
            builder.Property(x => x.PressNo).HasMaxLength(3);
            builder.Property(x => x.DataNo).HasMaxLength(3);
            builder.Property(x => x.MpsNo).HasMaxLength(9);
            builder.Property(x => x.CustomerOrderNo).HasMaxLength(10);
            builder.Property(x => x.SetItemCoLineNo).HasMaxLength(2);
            builder.Property(x => x.RoundUnit).HasMaxLength(1);
            builder.Property(x => x.PackingType).HasMaxLength(1);
            builder.Property(x => x.PackingPackageType).HasMaxLength(1);

            builder.Property(x => x.PackingLabelType).HasMaxLength(1);

            builder.Property(x => x.PackingLabelTypeSign).HasMaxLength(1);
            builder.Property(x => x.BoxLabelType).HasMaxLength(1);
            builder.Property(x => x.BoxLabelPrintType).HasMaxLength(1);

            builder.Property(x => x.VendorCode).HasMaxLength(4);
            builder.Property(x => x.ExternalFabricationPoNo).HasMaxLength(9);
            builder.Property(x => x.NicknameNo).HasMaxLength(12);

            builder.Property(x => x.MaterialMark1).HasMaxLength(8);
            builder.Property(x => x.CompoundMark1).HasMaxLength(8);
            builder.Property(x => x.MaterialMark2).HasMaxLength(8);
            builder.Property(x => x.CompoundMark2).HasMaxLength(8);
            builder.Property(x => x.MetalCaseMaterialCode).HasMaxLength(8);
            builder.Property(x => x.SpringMaterialCode).HasMaxLength(8);
            builder.Property(x => x.OtherMaterialType).HasMaxLength(8);
            builder.Property(x => x.PartialShipmentSign).HasMaxLength(1);
            builder.Property(x => x.DeliveryType).HasMaxLength(1);
            builder.Property(x => x.InternalOrderFromPlantCode).HasMaxLength(4);
            builder.Property(x => x.CostAccountingDivision).HasMaxLength(2);
            builder.Property(x => x.InternalOrderFromSector).HasMaxLength(4);

            builder.Property(x => x.StockItemSign).HasMaxLength(1);

            builder.Property(x => x.CapabilitySign).HasMaxLength(1);
            builder.Property(x => x.OrderType).HasMaxLength(1);
            builder.Property(x => x.LatestLabelSign).HasMaxLength(1);

            builder.Property(x => x.ReScheduleSign).HasMaxLength(1);
            builder.Property(x => x.PartsPurchaseOrderSign).HasMaxLength(1);
            builder.Property(x => x.SpecialSpecificationSign).HasMaxLength(1);

            builder.Property(x => x.InternalImportantSign1).HasMaxLength(1);
            builder.Property(x => x.FirstMassProductionRoute).HasMaxLength(1);
            builder.Property(x => x.CoatingMaterialType).HasMaxLength(8);
            builder.Property(x => x.Mold).HasMaxLength(20);
            builder.Property(x => x.MoldDivideSign).HasMaxLength(6);
            builder.Property(x => x.SpecialProcessCode).HasMaxLength(5);
            builder.Property(x => x.GoodItemControlSign).HasMaxLength(1);
            builder.Property(x => x.PressNo2).HasMaxLength(3);
            builder.Property(x => x.PressNo3).HasMaxLength(3);
            builder.Property(x => x.PressNo4).HasMaxLength(3);
            builder.Property(x => x.PressNo5).HasMaxLength(3);
            builder.Property(x => x.PressNo6).HasMaxLength(3);
            builder.Property(x => x.PressNo7).HasMaxLength(3);
            builder.Property(x => x.PressNo8).HasMaxLength(3);
            builder.Property(x => x.LotNo).HasMaxLength(10);
            builder.Property(x => x.PaperVerificationMark).HasMaxLength(2);
            builder.Property(x => x.UpdateRequestSign).HasMaxLength(1);
            builder.Property(x => x.DisposalSign).HasMaxLength(1);

            builder.Property(x => x.TagNo).HasMaxLength(2);

            builder.Property(x => x.TotalTagNo).HasMaxLength(2);
            builder.Property(x => x.StockDataType).HasMaxLength(1);
            builder.Property(x => x.TransactionNo).HasMaxLength(10);

            builder.Property(x => x.EntryNo).HasMaxLength(8);
            builder.Property(x => x.EntryLine).HasMaxLength(3);
            builder.Property(x => x.CompleteSign).HasMaxLength(1);
        }
    }
}
