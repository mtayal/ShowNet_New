using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class MEDIA_VIEW
    {
        public int ID { get; set; }
        public Nullable<int> Views { get; set; }
        public Nullable<System.DateTime> LastViewed { get; set; }
        public Nullable<int> MemberDetails { get; set; }
        public Nullable<int> Media { get; set; }
        public virtual Medium Medium { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS { get; set; }
    }
}
