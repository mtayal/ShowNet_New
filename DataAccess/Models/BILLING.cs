using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class BILLING
    {
        public int BILLING_ID { get; set; }
        public int AMOUNT { get; set; }
        public Nullable<int> QUANTITY { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<System.DateTime> TRANSACTION_DATE { get; set; }
        public System.DateTime DATE_CREATED { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> DATE_MODIFIED { get; set; }
        public string MODIFIED_BY { get; set; }
        public Nullable<int> ACCOUNTID { get; set; }
        public int BILLING_TYPE_ID { get; set; }
        public int PAYMENT_TYPE_ID { get; set; }
        public int TRANSACTION_STATUS { get; set; }
        public string TRANSACTION_NUMBER { get; set; }
        public string TRANSACTION_GATEWAY { get; set; }
        public virtual ACCOUNTING ACCOUNTING { get; set; }
        public virtual ACCOUNTING ACCOUNTING1 { get; set; }
        public virtual ACCOUNTING ACCOUNTING2 { get; set; }
        public virtual BILLING_TYPE BILLING_TYPE { get; set; }
        public virtual BILLING_TYPE BILLING_TYPE1 { get; set; }
    }
}
