using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Entities
{
    public class SiProErrorMaster
    {
        public string error_id { get; set; }
        public string error_name { get; set; }
        public string error_name_jp { get; set; }
        public string error_name_en { get; set; }
        public string entry_date { get; set; }
        public string entry_time { get; set; }
        public string entry_user { get; set; }
        public string location { get; set; }
        public string status { get; set; }
        public double error_max { get; set; }
    }
}
