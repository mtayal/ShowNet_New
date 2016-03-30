using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class EMAIL_LOGS
    {
        public int LogID { get; set; }
        public string MailTo { get; set; }
        public string MailCC { get; set; }
        public string MailBCC { get; set; }
        public string Mailbody { get; set; }
        public string MailSubject { get; set; }
        public byte[] TimeSent { get; set; }
        public Nullable<System.DateTime> TimeSent2 { get; set; }
    }
}
