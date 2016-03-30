using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class EMAIL_START_TIME
    {
        public int ID { get; set; }
        public string MailTo { get; set; }
        public string MailFrom { get; set; }
        public string MailSubject { get; set; }
        public Nullable<int> HorseShowID { get; set; }
        public string HorseShowName { get; set; }
        public string ClassName { get; set; }
        public Nullable<System.DateTime> OrigStartTime { get; set; }
        public Nullable<System.DateTime> NewStartTime { get; set; }
        public string MessageBody { get; set; }
        public Nullable<bool> IsProcessed { get; set; }
        public Nullable<int> ServiceID { get; set; }
        public Nullable<int> ClassID { get; set; }
        public Nullable<int> ScheduleID { get; set; }
        public Nullable<int> ShowDayID { get; set; }
        public Nullable<int> ServiceTypeID { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
