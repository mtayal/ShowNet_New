using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class SERVICE_TYPES
    {
        public int ServiceTypeID { get; set; }
        public string ServiceTypeName { get; set; }
        public string ServiceTypeDescription { get; set; }
        public Nullable<bool> ServiceTypeActive { get; set; }
        public Nullable<int> OrderIndex { get; set; }
    }
}
