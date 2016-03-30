using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VIEW_STREAMING_PURCHASE
    {
        public int PurchaseID { get; set; }
        public int MemberID { get; set; }
        public int ProductID { get; set; }
        public Nullable<int> AmountPaid { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public string UserName { get; set; }
        public Nullable<int> ProductCost { get; set; }
    }
}
