using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class PURCHASE_PROBLEMS
    {
        public int PurchaseProblemID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public string Message { get; set; }
    }
}
