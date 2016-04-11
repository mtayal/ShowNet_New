using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ViewShowPurchaseViewModel
    {
        public int PurchaseID { get; set; }
        public int MemberID { get; set; }
        public Nullable<int> HorseShowID { get; set; }
        public string HorseShowName { get; set; }
        public System.DateTime StartDate { get; set; }
        public int ProductID { get; set; }
        public Nullable<int> AmountPaid { get; set; }
        public Nullable<int> CircuitID { get; set; }
    }
}
