using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class CHANNEL_SPONSOR
    {
        public int ID { get; set; }
        public Nullable<int> SponsorID { get; set; }
        public Nullable<int> ChannelScheduleId { get; set; }
        public Nullable<bool> IsDisabled { get; set; }
    }
}
