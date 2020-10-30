using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Entities
{
    public class TmPostmachineOs
    {
        public string line_no { get; set; }
        public string press_no { get; set; }
        public string press_name { get; set; }
        public string location_cd { get; set; }
        public string temperature { get; set; }
        public string plc_m { get; set; }
        public string plc_m1 { get; set; }
        public string plc_m2 { get; set; }
        public string ip { get; set; }
        public int status { get; set; }
        public string time_use { get; set; }
        public string entry_date { get; set; }
        public string update_date { get; set; }
        public string plc_m3 { get; set; }
        public int post_cure_type { get; set; }
        public int mold_type { get; set; }
        public int trim_type { get; set; }
        public int devices { get; set; }
        public string memo { get; set; }
    }
}
