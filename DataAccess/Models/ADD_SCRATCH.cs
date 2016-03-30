using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ADD_SCRATCH
    {
        public int AddID { get; set; }
        public int HorseShowID { get; set; }
        public int ScheduleID { get; set; }
        public int BackID { get; set; }
        public bool Added { get; set; }
        public string Username { get; set; }
        public System.DateTime Entered { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public virtual SCHEDULE SCHEDULE { get; set; }
    }
}
