using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class AccountingViewModel
    {
        public int ACCOUNTID { get; set; }
        public int MEMBERID { get; set; }
        public decimal STARTING_BALANCE { get; set; }
        public decimal BALANCE { get; set; }
        public decimal CREDIT_LIMIT { get; set; }
        public bool ENABLED { get; set; }
        public Nullable<System.DateTime> DATEMODIFIED { get; set; }
        public string MODIFIEDBY { get; set; }
        public int VERSION { get; set; }
        public Nullable<System.DateTime> DATECREATED { get; set; }
        public string CREATEDBY { get; set; }
    }
}
