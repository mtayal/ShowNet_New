using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class MEDIA_FAVOURITES
    {
        public int ID { get; set; }
        public Nullable<int> MediaID { get; set; }
        public Nullable<int> MemberID { get; set; }
    }
}
