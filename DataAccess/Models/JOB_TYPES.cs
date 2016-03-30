using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class JOB_TYPES
    {
        public JOB_TYPES()
        {
            this.JOBS = new List<JOB>();
            this.JOBS1 = new List<JOB>();
            this.JOBS2 = new List<JOB>();
        }

        public int JobTypeID { get; set; }
        public string Name { get; set; }
        public string FriendlyName { get; set; }
        public virtual ICollection<JOB> JOBS { get; set; }
        public virtual ICollection<JOB> JOBS1 { get; set; }
        public virtual ICollection<JOB> JOBS2 { get; set; }
    }
}
