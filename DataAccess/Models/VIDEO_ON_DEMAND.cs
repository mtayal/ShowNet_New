using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VIDEO_ON_DEMAND
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string ThumbNail { get; set; }
        public string Guid { get; set; }
        public Nullable<bool> IsDisabled { get; set; }
        public Nullable<int> Source { get; set; }
    }
}
