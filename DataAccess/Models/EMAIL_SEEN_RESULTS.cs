using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class EMAIL_SEEN_RESULTS
    {
        public int ID { get; set; }
        public Nullable<int> ServiceID { get; set; }
        public Nullable<int> HorseShowID { get; set; }
        public Nullable<int> ShowDayID { get; set; }
        public Nullable<int> ClassID { get; set; }
        public Nullable<int> BackNoTracking { get; set; }
        public Nullable<System.DateTime> EnteredTime { get; set; }
        public bool MailDelivered { get; set; }
        public Nullable<int> RingID { get; set; }
    }
}
