using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class CHANNEL_SCHEDULE
    {
        public int ID { get; set; }
        public Nullable<int> ShowDayId { get; set; }
        public Nullable<bool> IsDisabled { get; set; }
        public Nullable<bool> IsFree { get; set; }
        public Nullable<int> Channel { get; set; }
        public virtual SHOW_DATE SHOW_DATE { get; set; }
    }
}
