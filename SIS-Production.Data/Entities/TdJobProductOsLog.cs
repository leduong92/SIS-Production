using System;
using System.Collections.Generic;

namespace SIS_Production.Data.Entities
{
    public partial class TdJobProductOsLog
    {
        public string JobOrderNo { get; set; }
        public string LineNo { get; set; }
        public string PressNo { get; set; }
        public short MoldStatus { get; set; }
        public short TrimStatus { get; set; }
        public string EntryDate { get; set; }
        public string EntryTime { get; set; }
        public string EntryUser { get; set; }
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
        public string Memo { get; set; }
        public string StartWashingDate { get; set; }
        public string StartWashingTime { get; set; }
        public string StartWashingUser { get; set; }
    }
}
