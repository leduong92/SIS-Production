using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Entities
{
    public class TdSisCurRecord
    {
        public int id { get; set; }
        public string line_no { get; set; }
        public string press_no { get; set; }
        public string type { get; set; }
        public string start_date { get; set; }
        public string start_time { get; set; }
        public string start_user { get; set; }
        public string end_date { get; set; }
        public string end_time { get; set; }
        public string end_user { get; set; }
        public string reset_date { get; set; }
        public string reset_time { get; set; }
        public string reset_user { get; set; }
        public string active { get; set; }
        public string shift { get; set; }
        public string error_type { get; set; }

    }
}
