using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Medium
    {
        public Medium()
        {
            this.PURCHASES = new List<Purchase>();
            this.MEDIA_DEFERRED = new List<MEDIA_DEFERRED>();
            this.VIDEO_PUBLISH = new List<VIDEO_PUBLISH>();
            this.MEDIA_DEFERRED1 = new List<MEDIA_DEFERRED>();
            this.VIDEO_PUBLISH2 = new List<VIDEO_PUBLISH>();
            this.PURCHASES1 = new List<Purchase>();
            this.PURCHASES2 = new List<Purchase>();
            this.MEDIA_VIEW = new List<MEDIA_VIEW>();
        }

        public int MediaID { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public int Size { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Height { get; set; }
        public string ContentType { get; set; }
        public string Folder { get; set; }
        public byte[] Content { get; set; }
        public string OriginalFilename { get; set; }
        public string OriginalFolder { get; set; }
        public Nullable<bool> DeferedSave { get; set; }
        public Nullable<int> ListID { get; set; }
        public Nullable<int> LengthSeconds { get; set; }
        public Nullable<bool> HasIPhoneMedia { get; set; }
        public Nullable<bool> HasThumbnails { get; set; }
        public Nullable<int> VideoPublish { get; set; }
        public Nullable<bool> IsPublic { get; set; }
        public Nullable<bool> IsPartnerAvailable { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.Guid> FileGuid { get; set; }
        public Nullable<bool> HasFlashMedia { get; set; }
        public string IPhoneMediaFilename { get; set; }
        public string FlashMediaFilename { get; set; }
        public Nullable<bool> HasFLVMedia { get; set; }
        public Nullable<int> MediaType { get; set; }
        public string MimeType { get; set; }
        public Nullable<int> QualityScale { get; set; }
        public Nullable<int> ImageCount { get; set; }
        public Nullable<bool> HasWebMMedia { get; set; }
        public string WebMMediaFilename { get; set; }
        public Nullable<bool> HasAzure { get; set; }
        public string AzureFileType { get; set; }
        public string AzureBlobLocation { get; set; }
        public Nullable<bool> HasFLVAzure { get; set; }
        public Nullable<bool> HasMP4Azure { get; set; }
        public Nullable<bool> HasImagesAzure { get; set; }
        public bool HasWMVAzure { get; set; }
        public Nullable<int> PlaybackMediaLocation { get; set; }
        public byte[] PrivatizedMemberIDs { get; set; }
        public virtual ICollection<Purchase> PURCHASES { get; set; }
        public virtual ICollection<MEDIA_DEFERRED> MEDIA_DEFERRED { get; set; }
        public virtual ICollection<VIDEO_PUBLISH> VIDEO_PUBLISH { get; set; }
        public virtual VIDEO_PUBLISH VIDEO_PUBLISH1 { get; set; }
        public virtual ICollection<MEDIA_DEFERRED> MEDIA_DEFERRED1 { get; set; }
        public virtual ICollection<VIDEO_PUBLISH> VIDEO_PUBLISH2 { get; set; }
        public virtual ICollection<Purchase> PURCHASES1 { get; set; }
        public virtual ICollection<Purchase> PURCHASES2 { get; set; }
        public virtual VIDEO_PUBLISH VIDEO_PUBLISH3 { get; set; }
        public virtual ICollection<MEDIA_VIEW> MEDIA_VIEW { get; set; }
    }
}
