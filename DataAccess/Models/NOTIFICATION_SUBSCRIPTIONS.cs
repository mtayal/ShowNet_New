using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class NOTIFICATION_SUBSCRIPTIONS
    {
        public int JobID { get; set; }
        public int MemberID { get; set; }
        public virtual JOB JOB { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS1 { get; set; }
        public virtual NOTIFICATION_JOBS NOTIFICATION_JOBS { get; set; }
        public virtual NOTIFICATION_JOBS NOTIFICATION_JOBS1 { get; set; }
    }
}
