using System;
using System.Collections.Generic;

namespace SIS_Production.Data.Entities
{
    public class SiProErrorMaster
    {
        public string ErrorId { get; set; }
        public string ErrorName { get; set; }
        public string ErrorNameJp { get; set; }
        public string ErrorNameEn { get; set; }
        public string EntryDate { get; set; }
        public string EntryTime { get; set; }
        public string EntryUser { get; set; }
        public string Location { get; set; }
        public char? Status { get; set; }
        public double? ErrorMax { get; set; }
    }
}
