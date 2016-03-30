using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class MODE
    {
        public MODE()
        {
            this.SCHEDULEs = new List<SCHEDULE>();
            this.SCHEDULEs1 = new List<SCHEDULE>();
        }

        public int ModeID { get; set; }
        public string ModeName { get; set; }
        public int OrderIndex { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public virtual ICollection<SCHEDULE> SCHEDULEs { get; set; }
        public virtual ICollection<SCHEDULE> SCHEDULEs1 { get; set; }
    }
}
