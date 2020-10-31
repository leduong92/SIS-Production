using System;
using System.Collections.Generic;

namespace SIS_Production.Data.Entities
{
    public partial class TdJobPrmoldOs
    {
        public string JobOrderNo { get; set; }
        public string LineNo { get; set; }
        public string PressNo { get; set; }
        public string PressName { get; set; }
        public short? RubberCount { get; set; }
        public short? MetalcaseCount { get; set; }
        public short? RubberTotal { get; set; }
        public short? MetalcaseTotal { get; set; }
        public short? Status { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string StartUser { get; set; }
        public string EndDate { get; set; }
        public string EndTime { get; set; }
        public string EndUser { get; set; }
        public string RejectDate { get; set; }
        public string RejectTime { get; set; }
        public string RejectUser { get; set; }
        public string WashingDate { get; set; }
        public string WashingTime { get; set; }
        public string WashingUser { get; set; }
        public int? WashingStatus { get; set; }
        public string StartWashingDate { get; set; }
        public string StartWashingTime { get; set; }
        public string StartWashingUser { get; set; }
        public string StartDate01 { get; set; }
        public string StartTime01 { get; set; }
        public string StartUser01 { get; set; }
    }
}
