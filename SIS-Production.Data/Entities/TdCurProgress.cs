using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Entities
{
    public class TdCurProgress
    {
        public string operation_code { get; set; }
        public int operation_sequence { get; set; }
        public string operation_name { get; set; }
        public string special_sign { get; set; }
    }
}
