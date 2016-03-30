using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class MEMBER_GROUP
    {
        public int ID { get; set; }
        public Nullable<int> Member { get; set; }
        public Nullable<int> AssociatedMember { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS1 { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS2 { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS3 { get; set; }
    }
}
