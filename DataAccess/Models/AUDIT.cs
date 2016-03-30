using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class AUDIT
    {
        public int ID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public string IPAddress { get; set; }
        public string SiteLocation { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public string UserAgent { get; set; }
        public string SessionID { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS1 { get; set; }
    }
}
