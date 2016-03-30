using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class SCHEDULE
    {
        public SCHEDULE()
        {
            this.ADD_SCRATCH = new List<ADD_SCRATCH>();
            this.ORDERED_GO_LIST = new List<ORDERED_GO_LIST>();
            this.ORDERED_GO_LIST1 = new List<ORDERED_GO_LIST>();
            this.ORDERED_GO_LIST2 = new List<ORDERED_GO_LIST>();
            this.VIDEO_STREAM = new List<VIDEO_STREAM>();
            this.VIDEO_STREAM1 = new List<VIDEO_STREAM>();
        }

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
        public virtual ICollection<ADD_SCRATCH> ADD_SCRATCH { get; set; }
        public virtual MODE MODE { get; set; }
        public virtual MODE MODE1 { get; set; }
        public virtual ICollection<ORDERED_GO_LIST> ORDERED_GO_LIST { get; set; }
        public virtual ICollection<ORDERED_GO_LIST> ORDERED_GO_LIST1 { get; set; }
        public virtual ICollection<ORDERED_GO_LIST> ORDERED_GO_LIST2 { get; set; }
        public virtual SHOW_DATE SHOW_DATE { get; set; }
        public virtual ICollection<VIDEO_STREAM> VIDEO_STREAM { get; set; }
        public virtual SHOW_DATE SHOW_DATE1 { get; set; }
        public virtual ICollection<VIDEO_STREAM> VIDEO_STREAM1 { get; set; }
        public virtual SHOW_DATE SHOW_DATE2 { get; set; }
    }
}
