using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VIEW_MOBILE_MEDIA_SHOW_PURCHASE
    {
        public int PurchaseID { get; set; }
        public int MediaID { get; set; }
        public int MemberID { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> ListID { get; set; }
        public string RiderName { get; set; }
        public string HorseName { get; set; }
        public string Trainer { get; set; }
        public Nullable<bool> HasIPhoneMedia { get; set; }
        public string ClassName { get; set; }
        public string ClassID { get; set; }
        public string HorseShowName { get; set; }
        public int ProductID { get; set; }
        public int HorseShowID { get; set; }
        public int BackID { get; set; }
        public Nullable<int> AmountPaid { get; set; }
        public string FileName { get; set; }
        public string Folder { get; set; }
        public Nullable<int> IncludeFromProduct { get; set; }
        public string AzureBlobLocation { get; set; }
        public Nullable<System.Guid> FileGuid { get; set; }
        public Nullable<int> MediaType { get; set; }
        public Nullable<bool> HasFLVAzure { get; set; }
        public bool HasWMVAzure { get; set; }
        public Nullable<bool> HasMP4Azure { get; set; }
        public int ScheduleID { get; set; }
        public byte[] PrivatizedMemberIDs { get; set; }
    }
}
