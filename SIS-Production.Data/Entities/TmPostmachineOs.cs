using System;
using System.Collections.Generic;

namespace SIS_Production.Data.Entities
{
    public partial class TmPostmachineOs
    {
        public string LineNo { get; set; }
        public string PressNo { get; set; }
        public string PressName { get; set; }
        public string LocationCd { get; set; }
        public int? Temperature { get; set; }
        public string PlcM { get; set; }
        public string PlcM1 { get; set; }
        public string PlcM2 { get; set; }
        public string Ip { get; set; }
        public int? Status { get; set; }
        public string TimeUse { get; set; }
        public string EntryDate { get; set; }
        public string UpdateDate { get; set; }
        public string PlcM3 { get; set; }
        public int? PostCureType { get; set; }
        public int? MoldType { get; set; }
        public int? TrimType { get; set; }
        public int? Devices { get; set; }
        public string Memo { get; set; }
    }
}
