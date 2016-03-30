using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VIEW_MEDIA_SEARCH
    {
        public int BackID { get; set; }
        public string HorseName { get; set; }
        public string Owner1 { get; set; }
        public string Rider { get; set; }
        public int HorseShowID { get; set; }
        public string HorseShowName { get; set; }
        public int ListID { get; set; }
        public string RiderName { get; set; }
        public int MediaID { get; set; }
        public string ClassID { get; set; }
        public string ClassName { get; set; }
        public Nullable<bool> HasIPhoneMedia { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<bool> HasThumbnails { get; set; }
        public Nullable<bool> HasMP4Azure { get; set; }
        public string AzureBlobLocation { get; set; }
        public Nullable<int> MediaType { get; set; }
        public Nullable<System.Guid> FileGUID { get; set; }
        public string Folder { get; set; }
        public string Filename { get; set; }
        public Nullable<bool> HasFLVAzure { get; set; }
        public int ScheduleID { get; set; }
    }
}
