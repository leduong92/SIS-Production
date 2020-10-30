using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Entities
{
    public class TdCurProgressMaster
    {
        public string finished_goods_code { get; set; }
        public string operation_code { get; set; }
        public string operation_name { get; set; }
        public int operation_sequence { get; set; }
        public string check_process_sign { get; set; }
    }
}