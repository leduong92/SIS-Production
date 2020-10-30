using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Entities
{
    public class TdJobProductOsLog
    {
        public string job_order_no { get; set; }
        public string line_no { get; set; }
        public string press_no { get; set; }
        public int mold_status { get; set; }
        public int trim_status { get; set; }
        public string entry_date { get; set; }
        public string entry_time { get; set; }
        public string entry_user { get; set; }
        public string start_date { get; set; }
        public string start_time { get; set; }
        public string start_user { get; set; }
        public string end_date { get; set; }
        public string end_time { get; set; }
        public string end_user { get; set; }
        public string reject_date { get; set; }
        public string reject_time { get; set; }
        public string reject_user { get; set; }
        public string washing_date { get; set; }
        public string washing_time { get; set; }
        public string washing_user { get; set; }
        public string memo { get; set; }
        public string start_washing_date { get; set; }
        public string start_washing_time { get; set; }
        public string start_washing_user { get; set; }
    }
}
