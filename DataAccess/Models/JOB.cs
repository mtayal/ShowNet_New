using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class JOB
    {
        public JOB()
        {
            this.JOB_SCHEDULES = new List<JOB_SCHEDULES>();
            this.JOB_SCHEDULES1 = new List<JOB_SCHEDULES>();
            this.JOB_SCHEDULES2 = new List<JOB_SCHEDULES>();
            this.NOTIFICATION_SUBSCRIPTIONS = new List<NOTIFICATION_SUBSCRIPTIONS>();
        }

        public int JobID { get; set; }
        public int Version { get; set; }
        public System.DateTime CreatedDateUtc { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateUtc { get; set; }
        public string ModifiedBy { get; set; }
        public bool ReadOnly { get; set; }
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public int TriggerType { get; set; }
        public int JobTypeID { get; set; }
        public string Description { get; set; }
        public virtual ICollection<JOB_SCHEDULES> JOB_SCHEDULES { get; set; }
        public virtual ICollection<JOB_SCHEDULES> JOB_SCHEDULES1 { get; set; }
        public virtual ICollection<JOB_SCHEDULES> JOB_SCHEDULES2 { get; set; }
        public virtual JOB_TYPES JOB_TYPES { get; set; }
        public virtual JOB_TYPES JOB_TYPES1 { get; set; }
        public virtual JOB_TYPES JOB_TYPES2 { get; set; }
        public virtual NOTIFICATION_JOBS NOTIFICATION_JOBS { get; set; }
        public virtual ICollection<NOTIFICATION_SUBSCRIPTIONS> NOTIFICATION_SUBSCRIPTIONS { get; set; }
        public virtual NOTIFICATION_JOBS NOTIFICATION_JOBS1 { get; set; }
        public virtual NOTIFICATION_JOBS NOTIFICATION_JOBS2 { get; set; }
    }
}
