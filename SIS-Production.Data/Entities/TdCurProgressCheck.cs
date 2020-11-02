using System;
using System.Collections.Generic;

namespace SIS_Production.Data.Entities
{
    public partial class TdCurProgressCheck
    {
        public string JobOrderNo { get; set; }
        public string FinishedGoodsCode { get; set; }
        public string OperationCode { get; set; }
        public short? OperationSequence { get; set; }
        public int? OrderDate { get; set; }
        public int? FinishedQty { get; set; }
        public int? NgQty { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string StartUser { get; set; }
        public string EndDate { get; set; }
        public string EndTime { get; set; }
        public string EndUser { get; set; }
        public string NgDate { get; set; }
        public string NgTime { get; set; }
        public string NgUser { get; set; }
        public short? Status { get; set; }
        public string MachineNo { get; set; }
        public string ConfirmDate { get; set; }
        public string ConfirmTime { get; set; }
        public string ConfirmUser { get; set; }
        public int CycleQty { get; set; }
    }
}
