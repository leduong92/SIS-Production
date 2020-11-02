using System;
using System.Collections.Generic;

namespace SIS_Production.Data.Entities
{
    public partial class TdCurMoldLog
    {
        public string MoldUp { get; set; }
        public string MoldDown { get; set; }
        public string SetupDate { get; set; }
        public string SetupTime { get; set; }
        public string SetupUser { get; set; }
        public string PrepareDate { get; set; }
        public string PrepareTime { get; set; }
        public string PrepareUser { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string StartUser { get; set; }
        public string EndDate { get; set; }
        public string EndTime { get; set; }
        public string EndUser { get; set; }
        public string ProUser { get; set; }
        public string Status { get; set; }
        public string MoldJob { get; set; }
        public string ConfirmUser { get; set; }
        public string MoldRackNo { get; set; }
        public string ReceiveWashDate { get; set; }
        public string ReceiveWashTime { get; set; }
        public string ReceiveWashUser { get; set; }
        public string ReceiveWashProUser { get; set; }
        public string StartWashDate { get; set; }
        public string StartWashTime { get; set; }
        public string StartWashUser { get; set; }
        public string EndWashDate { get; set; }
        public string EndWashTime { get; set; }
        public string EndWashUser { get; set; }
        public string OldMoldJob { get; set; }
        public string DeliveryDate { get; set; }
        public string DeliveryTime { get; set; }
        public string DeliveryUser { get; set; }
        public string GroupId { get; set; }
        public string EndProdDate { get; set; }
        public string EndProdTime { get; set; }
        public string EndProdUser { get; set; }
        public string LocationCd { get; set; }
    }
}
