using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class MEDIA_DEFERRED
    {
        public int DeferredMediaID { get; set; }
        public int MediaID { get; set; }
        public int ListID { get; set; }
        public bool IsProcessed { get; set; }
        public Nullable<int> MediaDeferredID { get; set; }
        public virtual Medium Medium { get; set; }
        public virtual Medium Medium1 { get; set; }
    }
}
