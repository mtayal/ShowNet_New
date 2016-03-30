using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VIEW_ALL_STREAMING_PURCHASE
    {
        public int PurchaseID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> AmountPaid { get; set; }
        public Nullable<int> ProductCost { get; set; }
        public string UserName { get; set; }
        public Nullable<int> ChannelID { get; set; }
    }
}
