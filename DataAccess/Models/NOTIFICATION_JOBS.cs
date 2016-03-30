using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class NOTIFICATION_JOBS
    {
        public NOTIFICATION_JOBS()
        {
            this.NOTIFICATION_SUBSCRIPTIONS = new List<NOTIFICATION_SUBSCRIPTIONS>();
            this.NOTIFICATION_SUBSCRIPTIONS1 = new List<NOTIFICATION_SUBSCRIPTIONS>();
        }

        public int JobID { get; set; }
        public int DeliveryMethods { get; set; }
        public int Category { get; set; }
        public virtual JOB JOB { get; set; }
        public virtual JOB JOB1 { get; set; }
        public virtual JOB JOB2 { get; set; }
        public virtual ICollection<NOTIFICATION_SUBSCRIPTIONS> NOTIFICATION_SUBSCRIPTIONS { get; set; }
        public virtual ICollection<NOTIFICATION_SUBSCRIPTIONS> NOTIFICATION_SUBSCRIPTIONS1 { get; set; }
    }
}
