using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class CHANNEL
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public string Link { get; set; }
        public string ThumbNail { get; set; }
        public string Guid { get; set; }
        public Nullable<bool> IsDisabled { get; set; }
        public Nullable<bool> IsLive { get; set; }
        public Nullable<int> MaxViewers { get; set; }
        public Nullable<System.DateTime> LastRefresh { get; set; }
        public Nullable<int> VodClips { get; set; }
        public Nullable<int> RecordedClips { get; set; }
        public Nullable<int> HorseShowID { get; set; }
        public int OrderIndex { get; set; }
        public Nullable<bool> IsGlobalFree { get; set; }
    }
}
