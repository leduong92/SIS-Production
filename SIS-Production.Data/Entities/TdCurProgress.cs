using System;
using System.Collections.Generic;

namespace SIS_Production.Data.Entities
{
    public partial class TdCurProgress
    {
        public string OperationCode { get; set; }
        public short OperationSequence { get; set; }
        public string OperationName { get; set; }
        public char? SpecialSign { get; set; }
    }
}
