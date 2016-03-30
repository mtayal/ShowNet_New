using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VIEW_DASHBOARD_MEDIA
    {
        public int MediaID { get; set; }
        public string ClassID { get; set; }
        public string ClassName { get; set; }
        public Nullable<int> PurchaseID { get; set; }
        public string HorseName { get; set; }
        public int BackID { get; set; }
        public int HorseShowID { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public string Folder { get; set; }
        public string FileName { get; set; }
        public Nullable<int> IncludeFromProduct { get; set; }
        public string AzureBlobLocation { get; set; }
        public Nullable<System.Guid> FileGuid { get; set; }
        public Nullable<int> MediaType { get; set; }
        public Nullable<bool> HasFLVAzure { get; set; }
        public bool HasWMVAzure { get; set; }
        public Nullable<bool> HasMP4Azure { get; set; }
    }
}
