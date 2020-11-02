using System;
using System.Collections.Generic;

namespace SIS_Production.Data.Entities
{
    public partial class TdSisCurRecord
    {
        public int Id { get; set; }
        public string LineNo { get; set; }
        public string PressNo { get; set; }
        public string Type { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string StartUser { get; set; }
        public string EndDate { get; set; }
        public string EndTime { get; set; }
        public string EndUser { get; set; }
        public string ResetDate { get; set; }
        public string ResetTime { get; set; }
        public string ResetUser { get; set; }
        public char? Active { get; set; }
        public string Shift { get; set; }
        public string ErrorType { get; set; }
    }
}
