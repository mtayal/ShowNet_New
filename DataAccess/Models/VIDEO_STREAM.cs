using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VIDEO_STREAM
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> ScheduledStart { get; set; }
        public Nullable<System.DateTime> ScheduledStop { get; set; }
        public string StreamUri { get; set; }
        public Nullable<bool> IsEnabled { get; set; }
        public Nullable<bool> IsFree { get; set; }
        public Nullable<int> HorseShow { get; set; }
        public Nullable<int> ShowDay { get; set; }
        public Nullable<int> Schedule { get; set; }
        public Nullable<bool> IsLive { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Height { get; set; }
        public string Stream { get; set; }
        public virtual HORSE_SHOW HORSE_SHOW { get; set; }
        public virtual HORSE_SHOW HORSE_SHOW1 { get; set; }
        public virtual SCHEDULE SCHEDULE1 { get; set; }
        public virtual SCHEDULE SCHEDULE2 { get; set; }
        public virtual SHOW_DATE SHOW_DATE { get; set; }
        public virtual SHOW_DATE SHOW_DATE1 { get; set; }
    }
}
