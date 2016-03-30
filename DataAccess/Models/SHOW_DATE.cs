using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class SHOW_DATE
    {
        public SHOW_DATE()
        {
            this.CHANNEL_SCHEDULE = new List<CHANNEL_SCHEDULE>();
            this.SCHEDULEs = new List<SCHEDULE>();
            this.SCHEDULEs1 = new List<SCHEDULE>();
            this.SCHEDULEs2 = new List<SCHEDULE>();
            this.VIDEO_STREAM = new List<VIDEO_STREAM>();
            this.VIDEO_STREAM1 = new List<VIDEO_STREAM>();
        }

        public int ShowDayID { get; set; }
        public int HorseShowID { get; set; }
        public System.DateTime ShowDate { get; set; }
        public int RingID { get; set; }
        public int CurrentSeqNo { get; set; }
        public System.DateTime StartTime { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public int CurSchedID1 { get; set; }
        public int CurSchedID2 { get; set; }
        public string Comment { get; set; }
        public virtual ICollection<CHANNEL_SCHEDULE> CHANNEL_SCHEDULE { get; set; }
        public virtual HORSE_SHOW HORSE_SHOW { get; set; }
        public virtual HORSE_SHOW HORSE_SHOW1 { get; set; }
        public virtual HORSE_SHOW HORSE_SHOW2 { get; set; }
        public virtual RING_NAME RING_NAME { get; set; }
        public virtual RING_NAME RING_NAME1 { get; set; }
        public virtual RING_NAME RING_NAME2 { get; set; }
        public virtual ICollection<SCHEDULE> SCHEDULEs { get; set; }
        public virtual ICollection<SCHEDULE> SCHEDULEs1 { get; set; }
        public virtual ICollection<SCHEDULE> SCHEDULEs2 { get; set; }
        public virtual ICollection<VIDEO_STREAM> VIDEO_STREAM { get; set; }
        public virtual ICollection<VIDEO_STREAM> VIDEO_STREAM1 { get; set; }
    }
}
