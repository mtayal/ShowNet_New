using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class MEMBER_FAVORITES
    {
        public int ID { get; set; }
        public int MemberID { get; set; }
        public Nullable<int> BackID { get; set; }
        public Nullable<int> HorseShowID { get; set; }
        public bool IsGUIVisible { get; set; }
        public virtual HORSE_SHOW HORSE_SHOW { get; set; }
        public virtual HORSE_SHOW HORSE_SHOW1 { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS1 { get; set; }
    }
}
