using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
   public class ScheduleViewModel
    {
        public int ScheduleID { get; set; }
        public int ShowDayID { get; set; }
        public string ClassID { get; set; }
        public string ClassName { get; set; }
        public bool Ordered { get; set; }
        public int SeqNo { get; set; }
        public int ModeID { get; set; }
        public Nullable<System.DateTime> ETA { get; set; }
        public string RingStatus { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public bool Deleted { get; set; }
        public bool Approved { get; set; }
        public Nullable<short> TimeAllowed1 { get; set; }
        public Nullable<short> R2Return { get; set; }
        public string Comment { get; set; }
        public Nullable<short> TimeAllowed2 { get; set; }
        public Nullable<int> RootScheduleID { get; set; }
        public Nullable<int> ParentScheduleID { get; set; }
    }
}
