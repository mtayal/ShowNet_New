using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class MEMBER_TRACKED_ENTRANTS
    {
        public int MemberID { get; set; }
        public int HorseShowID { get; set; }
        public int BackID { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS1 { get; set; }
    }
}
