using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class AVAILABLE_PURCHASE_BALANCE
    {
        public int ID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> ProductID { get; set; }
    }
}
