using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TrLblInfoNbcsConfiguration : IEntityTypeConfiguration<TrLblInfoNbcs>
    {
        public void Configure(EntityTypeBuilder<TrLblInfoNbcs> builder)
        {
            builder.ToTable("tr_lbl_info_nbcs");
            builder.HasKey(x => x.JobOrderNo);
            builder.HasKey(x => x.MpsNo);

            builder.HasIndex(x => x.FinishedGoodsCode);
            builder.HasIndex(x => x.EntryDate);

            builder.Property(x => x.RecordStatus).HasMaxLength(1);
            builder.Property(x => x.EntryTerminalId).HasMaxLength(10);
            builder.Property(x => x.ProgramId).HasMaxLength(10);
            builder.Property(x => x.UpdateUserCode).HasMaxLength(10);

            builder.Property(x => x.CompanyCode).HasMaxLength(5);

            builder.Property(x => x.PlantCode).HasMaxLength(4);
            builder.Property(x => x.MpsNo).HasMaxLength(9);
            builder.Property(x => x.DataTransferCompleteSign).HasMaxLength(1);
            builder.Property(x => x.ErrSign).HasMaxLength(5);
            builder.Property(x => x.JobOrderNo).HasMaxLength(12);
            builder.Property(x => x.SeqNo).HasMaxLength(6);
            builder.Property(x => x.ShipToAddress1).HasMaxLength(60);
            builder.Property(x => x.ShipToAddress2).HasMaxLength(60);
            builder.Property(x => x.ShipToCompanyName1).HasMaxLength(42);
            builder.Property(x => x.ShipToCompanyName2).HasMaxLength(28);
            builder.Property(x => x.LineGroup).HasMaxLength(6);
            builder.Property(x => x.ItemSign).HasMaxLength(1);
            builder.Property(x => x.MainStockLocation).HasMaxLength(4);
            builder.Property(x => x.ShipToStockLocation).HasMaxLength(4);
            builder.Property(x => x.PurchaseOrderNo).HasMaxLength(12);
            builder.Property(x => x.MadeInJapan).HasMaxLength(13);

            builder.Property(x => x.CustomerItem).HasMaxLength(62);
            builder.Property(x => x.CustomerCode).HasMaxLength(5);
            builder.Property(x => x.FinishedGoodsCode1).HasMaxLength(20);
            builder.Property(x => x.FinishedGoodsCode2).HasMaxLength(4);

            builder.Property(x => x.SpecialSpecificationSign).HasMaxLength(1);
            builder.Property(x => x.LargeLetterType).HasMaxLength(1);
            builder.Property(x => x.BoxLabelType).HasMaxLength(2);
            builder.Property(x => x.ShipLabel).HasMaxLength(10);
            builder.Property(x => x.StockAccountNo).HasMaxLength(5);
            builder.Property(x => x.LotNo).HasMaxLength(10);
            builder.Property(x => x.LocationNo).HasMaxLength(12);
            builder.Property(x => x.CustomerOrderNo).HasMaxLength(10);
            builder.Property(x => x.ShippingControlCode).HasMaxLength(4);
            builder.Property(x => x.PrintType).HasMaxLength(1);
            builder.Property(x => x.Address3).HasMaxLength(22);
            builder.Property(x => x.Address4).HasMaxLength(22);

            builder.Property(x => x.DeliveryPlace).HasMaxLength(8);

            builder.Property(x => x.Denominator).HasMaxLength(1);
            builder.Property(x => x.Filler).HasMaxLength(24);
            builder.Property(x => x.UpdateRequestSign).HasMaxLength(1);

            builder.Property(x => x.CustomerName).HasMaxLength(100);
            builder.Property(x => x.PackingLabelType).HasMaxLength(1);
            builder.Property(x => x.JisSign).HasMaxLength(1);

            builder.Property(x => x.CustomerCode).HasMaxLength(5);
            builder.Property(x => x.CustomerItem).HasMaxLength(30);
            builder.Property(x => x.CustUserInspPlace).HasMaxLength(4);
            builder.Property(x => x.CustUserLocNo).HasMaxLength(12);
            builder.Property(x => x.CustUserMainStkLoc).HasMaxLength(4);
            builder.Property(x => x.CustUserStkAccNo).HasMaxLength(5);
            builder.Property(x => x.PackingLabelTypeSign).HasMaxLength(1);
            builder.Property(x => x.BoxLabelPrintType).HasMaxLength(1);
            builder.Property(x => x.AdditionalSpecCode1).HasMaxLength(3);
            builder.Property(x => x.CocomSign).HasMaxLength(1);
            builder.Property(x => x.MaterialMark1).HasMaxLength(8);
            builder.Property(x => x.RohsSign).HasMaxLength(1);

            builder.Property(x => x.PaperVerificationMark).HasMaxLength(2);

            builder.Property(x => x.FoodApp).HasMaxLength(1);
            builder.Property(x => x.TraceNo).HasMaxLength(20);
            builder.Property(x => x.PackingLabelFormNo).HasMaxLength(10);

            builder.Property(x => x.BoxLabelFormNo).HasMaxLength(10);
            builder.Property(x => x.QrData).HasMaxLength(200);
            builder.Property(x => x.CustomerName1).HasMaxLength(50);

            builder.Property(x => x.CustomerName2).HasMaxLength(50);
            builder.Property(x => x.TransactionNo).HasMaxLength(10);
            builder.Property(x => x.FinishedGoodsCode).HasMaxLength(20);
            builder.Property(x => x.Notes1).HasMaxLength(42);
            builder.Property(x => x.UnitOfMeasure).HasMaxLength(3);
            builder.Property(x => x.DisposalSign).HasMaxLength(1);
            builder.Property(x => x.Comment01).HasMaxLength(25);
            builder.Property(x => x.Comment02).HasMaxLength(25);
            builder.Property(x => x.Comment03).HasMaxLength(25);
            builder.Property(x => x.Comment04).HasMaxLength(25);
            builder.Property(x => x.Comment05).HasMaxLength(25);

            builder.Property(x => x.StockDataType).HasMaxLength(1);

            builder.Property(x => x.CustomerNameForLabel).HasMaxLength(42);
            builder.Property(x => x.CustomerItemForLabel).HasMaxLength(42);
            builder.Property(x => x.CustPrintReqForLabel).HasMaxLength(42);

            builder.Property(x => x.ItemdDescriptionForLabel).HasMaxLength(42);
        }
    }
}
