using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PaymentCreditViewModel
    {
        public PaymentCreditViewModel()
        {
            this.AccountingObject = new AccountingViewModel();
            this.PurchaseObject = new PurchaseViewModel();
        }
        public AccountingViewModel AccountingObject { get; set; }
        public PurchaseViewModel PurchaseObject { get; set; }
        public IEnumerable<ViewEntrantMediaViewModel> ViewEntrantMediaList { get; set; }
        public IEnumerable<ViewPurchasesViewModel> ViewPurchasesList { get; set; }
    }
}
