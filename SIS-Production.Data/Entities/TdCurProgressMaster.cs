using System;
using System.Collections.Generic;

namespace SIS_Production.Data.Entities
{
    public partial class TdCurProgressMaster
    {
        public string FinishedGoodsCode { get; set; }
        public string OperationCode { get; set; }
        public string OperationName { get; set; }
        public short? OperationSequence { get; set; }
        public string CheckProcessSign { get; set; }
    }
}
