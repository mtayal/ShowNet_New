using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VIDEO_PUBLISH
    {
        public VIDEO_PUBLISH()
        {
            this.MEDIA1 = new List<Medium>();
            this.MEDIA2 = new List<Medium>();
            this.MEMBER_DETAILS1 = new List<MEMBER_DETAILS>();
            this.MEMBER_DETAILS3 = new List<MEMBER_DETAILS>();
        }

        public int ID { get; set; }
        public string PublishOutlet { get; set; }
        public string PublishUri { get; set; }
        public Nullable<System.DateTime> PublishTime { get; set; }
        public Nullable<bool> IsPublished { get; set; }
        public Nullable<bool> IsError { get; set; }
        public string ErrorMessage { get; set; }
        public Nullable<int> Media { get; set; }
        public Nullable<int> Member { get; set; }
        public virtual Medium Medium { get; set; }
        public virtual ICollection<Medium> MEDIA1 { get; set; }
        public virtual Medium Medium1 { get; set; }
        public virtual ICollection<Medium> MEDIA2 { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS { get; set; }
        public virtual ICollection<MEMBER_DETAILS> MEMBER_DETAILS1 { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS2 { get; set; }
        public virtual ICollection<MEMBER_DETAILS> MEMBER_DETAILS3 { get; set; }
    }
}
