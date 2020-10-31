using System;
using System.Collections.Generic;

namespace SIS_Production.Data.Entities
{
    public class SiProErrorDetail
    {
        public short ProgressOperationSeq { get; set; }
        public string ErrorId { get; set; }
        public string EntryDate { get; set; }
        public string EntryTime { get; set; }
        public string EntryUser { get; set; }
        public string Location { get; set; }
        public char? Status { get; set; }
        public string Department { get; set; }
        public string Area { get; set; }
        public string ProgramId { get; set; }
        public string ErrorDeptId { get; set; }
        public short? OrderId { get; set; }
    }
}
