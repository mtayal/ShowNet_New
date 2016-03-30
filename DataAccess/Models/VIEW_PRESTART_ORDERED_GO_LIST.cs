using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VIEW_PRESTART_ORDERED_GO_LIST
    {
        public int ListID { get; set; }
        public int ScheduleID { get; set; }
        public string ClassID { get; set; }
        public string ClassName { get; set; }
        public int ShowDayID { get; set; }
        public bool Ordered { get; set; }
        public Nullable<System.DateTime> ETA { get; set; }
        public int HorseShowID { get; set; }
        public string RiderName { get; set; }
        public string HorseShowName { get; set; }
        public string HorseName { get; set; }
        public string Rider { get; set; }
        public int RingID { get; set; }
        public string RingName { get; set; }
        public int BackID { get; set; }
        public int OrderIndex { get; set; }
        public System.DateTime ShowDate { get; set; }
        public string Owner1 { get; set; }
        public int ModeID { get; set; }
        public string Draw { get; set; }
        public int ShowMode { get; set; }
    }
}
