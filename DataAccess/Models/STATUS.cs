using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class STATUS
    {
        public STATUS()
        {
            this.ENTRANTS = new List<ENTRANT>();
        }

        public int StatusID { get; set; }
        public string StatusName { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public virtual ICollection<ENTRANT> ENTRANTS { get; set; }
    }
}
