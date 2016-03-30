using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class NCAA_ENTRANT
    {
        public NCAA_ENTRANT()
        {
            this.NCAA_ROUND = new List<NCAA_ROUND>();
            this.NCAA_ROUND1 = new List<NCAA_ROUND>();
            this.NCAA_ROUND2 = new List<NCAA_ROUND>();
            this.NCAA_ROUND3 = new List<NCAA_ROUND>();
        }

        public int EntrantID { get; set; }
        public Nullable<int> BackID { get; set; }
        public string HorseName { get; set; }
        public string Trainer { get; set; }
        public string Owner1 { get; set; }
        public string Owner2 { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public string Rider { get; set; }
        public string RiderAddr { get; set; }
        public string Owner1Addr { get; set; }
        public Nullable<int> Team { get; set; }
        public virtual NCAA_TEAM NCAA_TEAM { get; set; }
        public virtual ICollection<NCAA_ROUND> NCAA_ROUND { get; set; }
        public virtual ICollection<NCAA_ROUND> NCAA_ROUND1 { get; set; }
        public virtual ICollection<NCAA_ROUND> NCAA_ROUND2 { get; set; }
        public virtual ICollection<NCAA_ROUND> NCAA_ROUND3 { get; set; }
        public virtual NCAA_TEAM NCAA_TEAM1 { get; set; }
    }
}
