using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class NCAA_TEAM
    {
        public NCAA_TEAM()
        {
            this.NCAA_BRACKET = new List<NCAA_BRACKET>();
            this.NCAA_BRACKET1 = new List<NCAA_BRACKET>();
            this.NCAA_BRACKET2 = new List<NCAA_BRACKET>();
            this.NCAA_BRACKET3 = new List<NCAA_BRACKET>();
            this.NCAA_ENTRANT = new List<NCAA_ENTRANT>();
            this.NCAA_ENTRANT1 = new List<NCAA_ENTRANT>();
        }

        public int TeamID { get; set; }
        public Nullable<int> Seeding { get; set; }
        public string TeamName { get; set; }
        public Nullable<int> Schedule { get; set; }
        public virtual ICollection<NCAA_BRACKET> NCAA_BRACKET { get; set; }
        public virtual ICollection<NCAA_BRACKET> NCAA_BRACKET1 { get; set; }
        public virtual ICollection<NCAA_BRACKET> NCAA_BRACKET2 { get; set; }
        public virtual ICollection<NCAA_BRACKET> NCAA_BRACKET3 { get; set; }
        public virtual ICollection<NCAA_ENTRANT> NCAA_ENTRANT { get; set; }
        public virtual ICollection<NCAA_ENTRANT> NCAA_ENTRANT1 { get; set; }
        public virtual NCAA_SCHEUDLE NCAA_SCHEUDLE { get; set; }
        public virtual NCAA_SCHEUDLE NCAA_SCHEUDLE1 { get; set; }
    }
}
