using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Entities
{
    public class TdCurProgressCheck
    {
        public string job_order_no { get; set; }
        public string finished_goods_code { get; set; }
        public string operation_code { get; set; }
        public int operation_sequence { get; set; }
        public int order_date { get; set; }
        public int finished_qty { get; set; }
        public int ng_qty { get; set; }
        public string start_date { get; set; }
        public string start_time { get; set; }
        public string start_user { get; set; }
        public string end_date { get; set; }
        public string end_time { get; set; }
        public string end_user { get; set; }
        public string ng_date { get; set; }
        public string ng_time { get; set; }
        public string ng_user { get; set; }
        public int status { get; set; }
        public string machine_no { get; set; }
        public string confirm_date { get; set; }
        public string confirm_time { get; set; }
        public string confirm_user { get; set; }
        public string cycle_qty { get; set; }
    }
}
