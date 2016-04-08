using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PurchaseViewModel
    {
        public int PurchaseID { get; set; }
        public int ProductID { get; set; }
        public int MemberID { get; set; }
        public Nullable<int> MediaID { get; set; }
        public Nullable<int> HorseShowID { get; set; }
        public bool IsGUIVisible { get; set; }
        public Nullable<int> CircuitID { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> AmountPaid { get; set; }
        public Nullable<int> IncludeFromProduct { get; set; }
        public Nullable<System.DateTime> Expires { get; set; }
        public Nullable<int> DeliveryDetails { get; set; }
        public Nullable<int> ProductCost { get; set; }
        public Nullable<int> ChannelID { get; set; }
        public string Notes { get; set; }
        public Nullable<int> MemberBalance { get; set; }

        public string ProductName { get; set; }

        public string CurrentSubscription { get; set; }
    }
}
