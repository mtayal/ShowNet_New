using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class DASHBOARD_NOTIFICATION
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> JobID { get; set; }
    }
}
