using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class RING_NAME
    {
        public RING_NAME()
        {
            this.SHOW_DATE = new List<SHOW_DATE>();
            this.SHOW_DATE1 = new List<SHOW_DATE>();
            this.SHOW_DATE2 = new List<SHOW_DATE>();
        }

        public int RingID { get; set; }
        public string RingName { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public virtual ICollection<SHOW_DATE> SHOW_DATE { get; set; }
        public virtual ICollection<SHOW_DATE> SHOW_DATE1 { get; set; }
        public virtual ICollection<SHOW_DATE> SHOW_DATE2 { get; set; }
    }
}
