using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> ProductCost { get; set; }
        public string ProductDescription { get; set; }
        public Nullable<int> IncludedClipDownload { get; set; }
        public Nullable<int> IncludedOnlineViews { get; set; }
        public Nullable<int> IncludedMobileViews { get; set; }
        public Nullable<int> ExiresAfterMinutes { get; set; }
    }
}
