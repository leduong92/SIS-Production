using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Entities
{
    public class TdJobPrmoldOs
    {
        public string job_order_no { get; set; }
        public string line_no { get; set; }
        public string press_no { get; set; }
        public string press_name { get; set; }
        public int rubber_count { get; set; }
        public int metalcase_count { get; set; }
        public int rubber_total { get; set; }
        public int metalcase_total { get; set; }
        public int status { get; set; }
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
        public string washing_status { get; set; }
        public string start_washing_date { get; set; }
        public string start_washing_time { get; set; }
        public string start_washing_user { get; set; }
        public string start_date_01 { get; set; }
        public string start_time_01 { get; set; }
        public string start_user_01 { get; set; }
    }
}
