using System;
using System.Collections.Generic;

namespace SIS_Production.Data.Entities
{
    public partial class TrLblInfoNbcs
    {
        public char? RecordStatus { get; set; }
        public int? EntryDate { get; set; }
        public int? EntryTime { get; set; }
        public int? UpdateDate { get; set; }
        public int? UpdateTime { get; set; }
        public string EntryTerminalId { get; set; }
        public string ProgramId { get; set; }
        public string UpdateUserCode { get; set; }
        public string CompanyCode { get; set; }
        public string PlantCode { get; set; }
        public string MpsNo { get; set; }
        public char? DataTransferCompleteSign { get; set; }
        public string ErrSign { get; set; }
        public string JobOrderNo { get; set; }
        public string SeqNo { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToCompanyName1 { get; set; }
        public string ShipToCompanyName2 { get; set; }
        public string LineGroup { get; set; }
        public char? ItemSign { get; set; }
        public string MainStockLocation { get; set; }
        public string ShipToStockLocation { get; set; }
        public string PurchaseOrderNo { get; set; }
        public string MadeInJapan { get; set; }
        public string CustomerItem { get; set; }
        public string CustomerCode { get; set; }
        public string FinishedGoodsCode1 { get; set; }
        public string FinishedGoodsCode2 { get; set; }
        public char? SpecialSpecificationSign { get; set; }
        public char? LargeLetterType { get; set; }
        public string BoxLabelType { get; set; }
        public string ShipLabel { get; set; }
        public double? BoxQty { get; set; }
        public string StockAccountNo { get; set; }
        public string LotNo { get; set; }
        public string LocationNo { get; set; }
        public string CustomerOrderNo { get; set; }
        public string ShippingControlCode { get; set; }
        public char? PrintType { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string DeliveryPlace { get; set; }
        public char? Denominator { get; set; }
        public string Filler { get; set; }
        public char? UpdateRequestSign { get; set; }
        public string CustomerName { get; set; }
        public double? PackQty { get; set; }
        public char? PackingLabelType { get; set; }
        public char? JisSign { get; set; }
        public string CustUserCode { get; set; }
        public string CustUserItem { get; set; }
        public string CustUserInspPlace { get; set; }
        public string CustUserLocNo { get; set; }
        public string CustUserMainStkLoc { get; set; }
        public string CustUserStkAccNo { get; set; }
        public char? PackingLabelTypeSign { get; set; }
        public char? BoxLabelPrintType { get; set; }
        public string AdditionalSpecCode1 { get; set; }
        public char? CocomSign { get; set; }
        public string MaterialMark1 { get; set; }
        public char? RohsSign { get; set; }
        public string PaperVerificationMark { get; set; }
        public char? FoodApp { get; set; }
        public string TraceNo { get; set; }
        public string PackingLabelFormNo { get; set; }
        public string BoxLabelFormNo { get; set; }
        public string QrData { get; set; }
        public string CustomerName1 { get; set; }
        public string CustomerName2 { get; set; }
        public string TransactionNo { get; set; }
        public string FinishedGoodsCode { get; set; }
        public string Notes1 { get; set; }
        public string UnitOfMeasure { get; set; }
        public char? DisposalSign { get; set; }
        public string Comment01 { get; set; }
        public string Comment02 { get; set; }
        public string Comment03 { get; set; }
        public string Comment04 { get; set; }
        public string Comment05 { get; set; }
        public char? StockDataType { get; set; }
        public string CustomerNameForLabel { get; set; }
        public string CustomerItemForLabel { get; set; }
        public string CustPrintReqForLabel { get; set; }
        public string ItemdDescriptionForLabel { get; set; }
    }
}
