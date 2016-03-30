using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class NCAA_SCHEUDLE
    {
        public NCAA_SCHEUDLE()
        {
            this.NCAA_BRACKET = new List<NCAA_BRACKET>();
            this.NCAA_BRACKET1 = new List<NCAA_BRACKET>();
            this.NCAA_TEAM = new List<NCAA_TEAM>();
            this.NCAA_TEAM1 = new List<NCAA_TEAM>();
        }

        public int ScheduleID { get; set; }
        public string ScheduleName { get; set; }
        public Nullable<System.DateTime> ETA { get; set; }
        public string RingStatus { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<bool> Approved { get; set; }
        public string Comment { get; set; }
        public Nullable<int> Show { get; set; }
        public virtual ICollection<NCAA_BRACKET> NCAA_BRACKET { get; set; }
        public virtual ICollection<NCAA_BRACKET> NCAA_BRACKET1 { get; set; }
        public virtual NCAA_SHOW NCAA_SHOW { get; set; }
        public virtual ICollection<NCAA_TEAM> NCAA_TEAM { get; set; }
        public virtual NCAA_SHOW NCAA_SHOW1 { get; set; }
        public virtual ICollection<NCAA_TEAM> NCAA_TEAM1 { get; set; }
    }
}
