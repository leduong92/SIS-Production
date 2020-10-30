using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Entities
{
    public class SiProErrorDetail
    {
        public int progress_operation_seq { get; set; }
        public string error_id { get; set; }
        public string entry_date { get; set; }
        public string entry_time { get; set; }
        public string entry_user { get; set; }
        public string location { get; set; }
        public string status { get; set; }
        public string department { get; set; }
        public string area { get; set; }
        public string program_id { get; set; }
        public string error_dept_id { get; set; }
        public int order_id { get; set; }
    }
}
