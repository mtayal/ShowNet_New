using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ENTRANTS_GONE
    {
        public int GoneEntrantID { get; set; }
        public int ListID { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> ScheduleID { get; set; }
    }
}
