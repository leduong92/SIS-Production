using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Entities
{
    public class TdCurMoldLog
    {
        public string mold_up { get; set; }
        public string mold_down { get; set; }
        public string setup_date { get; set; }
        public string setup_time { get; set; }
        public string setup_user { get; set; }
        public string prepare_date { get; set; }
        public string prepare_time { get; set; }
        public string prepare_user { get; set; }
        public string start_date { get; set; }
        public string start_time { get; set; }
        public string start_user { get; set; }
        public string end_date { get; set; }
        public string end_time { get; set; }
        public string end_user { get; set; }
        public string pro_user { get; set; }
        public string status { get; set; }
        public string mold_job { get; set; }
        public string confirm_user { get; set; }
        public string mold_rack_no { get; set; }
        public string receive_wash_date { get; set; }
        public string receive_wash_time { get; set; }
        public string receive_wash_user { get; set; }
        public string receive_wash_pro_user { get; set; }
        public string start_wash_date { get; set; }
        public string start_wash_time { get; set; }
        public string start_wash_user { get; set; }
        public string end_wash_date { get; set; }
        public string end_wash_time { get; set; }
        public string end_wash_user { get; set; }
        public string old_mold_job { get; set; }
        public string delivery_date { get; set; }
        public string delivery_time { get; set; }
        public string delivery_user { get; set; }
        public string group_id { get; set; }
        public string end_prod_date { get; set; }
        public string end_prod_time { get; set; }
        public string end_prod_user { get; set; }
        public string location_cd { get; set; }
    }
}
