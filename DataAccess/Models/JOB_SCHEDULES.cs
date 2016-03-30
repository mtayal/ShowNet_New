using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class JOB_SCHEDULES
    {
        public int JobScheduleID { get; set; }
        public int Version { get; set; }
        public int JobID { get; set; }
        public System.DateTime StartDateUtc { get; set; }
        public int Frequency { get; set; }
        public int FrequencyInterval { get; set; }
        public bool Enabled { get; set; }
        public virtual JOB JOB { get; set; }
        public virtual JOB JOB1 { get; set; }
        public virtual JOB JOB2 { get; set; }
    }
}
