using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class SHOW_MESSAGES_RELATIONSHIPS
    {
        public int ShowMessagesID { get; set; }
        public int HorseShowID { get; set; }
        public int MemberID { get; set; }
        public bool Active { get; set; }
        public virtual HORSE_SHOW HORSE_SHOW { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS { get; set; }
    }
}
