using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class MEMBER_SERVICES
    {
        public int ServiceID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<int> HorseShowID { get; set; }
        public Nullable<bool> EmailService { get; set; }
        public Nullable<int> BackNoTracking { get; set; }
        public bool IsProcessed { get; set; }
        public Nullable<int> ServiceTypeID { get; set; }
        public Nullable<System.DateTime> LastSent { get; set; }
    }
}
