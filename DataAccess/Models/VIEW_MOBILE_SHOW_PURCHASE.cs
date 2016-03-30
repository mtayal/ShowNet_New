using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VIEW_MOBILE_SHOW_PURCHASE
    {
        public int PurchaseID { get; set; }
        public int MemberID { get; set; }
        public Nullable<int> HorseShowID { get; set; }
        public string HorseShowName { get; set; }
        public System.DateTime StartDate { get; set; }
        public int ProductID { get; set; }
        public Nullable<int> AmountPaid { get; set; }
    }
}
