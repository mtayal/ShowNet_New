using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class MEMBER_DETAILS
    {
        public MEMBER_DETAILS()
        {
            this.ACCOUNTINGs = new List<ACCOUNTING>();
            this.ACCOUNTINGs1 = new List<ACCOUNTING>();
            this.ACCOUNTINGs2 = new List<ACCOUNTING>();
            this.AUDITs = new List<AUDIT>();
            this.AUDITs1 = new List<AUDIT>();
            this.DELIVERY_DETAILS = new List<DELIVERY_DETAILS>();
            this.MEDIA_VIEW = new List<MEDIA_VIEW>();
            this.PURCHASES = new List<Purchase>();
            this.SHOW_MESSAGES_RELATIONSHIPS = new List<SHOW_MESSAGES_RELATIONSHIPS>();
            this.MEMBER_TRACKED_ENTRANTS = new List<MEMBER_TRACKED_ENTRANTS>();
            this.VIDEO_PUBLISH = new List<VIDEO_PUBLISH>();
            this.MEMBER_FAVORITES = new List<MEMBER_FAVORITES>();
            this.MEMBER_GROUP = new List<MEMBER_GROUP>();
            this.MEMBER_GROUP1 = new List<MEMBER_GROUP>();
            this.VIDEO_PUBLISH2 = new List<VIDEO_PUBLISH>();
            this.MEMBER_GROUP2 = new List<MEMBER_GROUP>();
            this.MEMBER_GROUP3 = new List<MEMBER_GROUP>();
            this.PURCHASES1 = new List<Purchase>();
            this.NOTIFICATION_SUBSCRIPTIONS = new List<NOTIFICATION_SUBSCRIPTIONS>();
            this.MEMBER_FAVORITES1 = new List<MEMBER_FAVORITES>();
            this.PURCHASES2 = new List<Purchase>();
            this.NOTIFICATION_SUBSCRIPTIONS1 = new List<NOTIFICATION_SUBSCRIPTIONS>();
            this.MEMBER_TRACKED_ENTRANTS1 = new List<MEMBER_TRACKED_ENTRANTS>();
        }

        public int MemberID { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordHint { get; set; }
        public Nullable<System.DateTime> DateJoined { get; set; }
        public Nullable<int> TypeID { get; set; }
        public string MemberStatus { get; set; }
        public string AreaCode { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string sms { get; set; }
        public Nullable<bool> MessageNotification { get; set; }
        public Nullable<System.Guid> ActivationGUID { get; set; }
        public string AlertEmail { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public string iPhoneDeviceGUID { get; set; }
        public Nullable<bool> SendPushNotification { get; set; }
        public string CircuitSalesReportList { get; set; }
        public string ShowSalesReportList { get; set; }
        public Nullable<bool> IsAdmin { get; set; }
        public Nullable<bool> IsSalesAdmin { get; set; }
        public string TwitterUsername { get; set; }
        public string TwitterOAuthToken { get; set; }
        public string TwitterOAuthSecret { get; set; }
        public Nullable<bool> TwitterIsPublic { get; set; }
        public string FacebookUsername { get; set; }
        public string FacebookOAuthToken { get; set; }
        public string FacebookOAuthSecret { get; set; }
        public Nullable<bool> FacebookIsPublic { get; set; }
        public Nullable<int> VideoPublish { get; set; }
        public string BlackBerryDeviceID { get; set; }
        public string iPhoneNotificationGUID { get; set; }
        public string AndroidDeviceGUID { get; set; }
        public string AndroidNotificationGUID { get; set; }
        public Nullable<bool> iPhonePushNotification { get; set; }
        public Nullable<bool> AndroidPushNotification { get; set; }
        public Nullable<bool> BlackBerryPushNotification { get; set; }
        public Nullable<bool> TwitterNotification { get; set; }
        public Nullable<bool> FacebookNotification { get; set; }
        public Nullable<long> FacebookProfileId { get; set; }
        public Nullable<int> Partner { get; set; }
        public Nullable<int> Mode { get; set; }
        public Nullable<int> DefaultDeliveryDetails { get; set; }
        public Nullable<bool> HasSeenUpgrade { get; set; }
        public virtual ICollection<ACCOUNTING> ACCOUNTINGs { get; set; }
        public virtual ICollection<ACCOUNTING> ACCOUNTINGs1 { get; set; }
        public virtual ICollection<ACCOUNTING> ACCOUNTINGs2 { get; set; }
        public virtual ICollection<AUDIT> AUDITs { get; set; }
        public virtual ICollection<AUDIT> AUDITs1 { get; set; }
        public virtual ICollection<DELIVERY_DETAILS> DELIVERY_DETAILS { get; set; }
        public virtual DELIVERY_DETAILS DELIVERY_DETAILS1 { get; set; }
        public virtual ICollection<MEDIA_VIEW> MEDIA_VIEW { get; set; }
        public virtual MEMBER_TYPE MEMBER_TYPE { get; set; }
        public virtual ICollection<Purchase> PURCHASES { get; set; }
        public virtual ICollection<SHOW_MESSAGES_RELATIONSHIPS> SHOW_MESSAGES_RELATIONSHIPS { get; set; }
        public virtual ICollection<MEMBER_TRACKED_ENTRANTS> MEMBER_TRACKED_ENTRANTS { get; set; }
        public virtual ICollection<VIDEO_PUBLISH> VIDEO_PUBLISH { get; set; }
        public virtual ICollection<MEMBER_FAVORITES> MEMBER_FAVORITES { get; set; }
        public virtual ICollection<MEMBER_GROUP> MEMBER_GROUP { get; set; }
        public virtual ICollection<MEMBER_GROUP> MEMBER_GROUP1 { get; set; }
        public virtual PARTNER PARTNER1 { get; set; }
        public virtual MEMBER_TYPE MEMBER_TYPE1 { get; set; }
        public virtual VIDEO_PUBLISH VIDEO_PUBLISH1 { get; set; }
        public virtual ICollection<VIDEO_PUBLISH> VIDEO_PUBLISH2 { get; set; }
        public virtual ICollection<MEMBER_GROUP> MEMBER_GROUP2 { get; set; }
        public virtual ICollection<MEMBER_GROUP> MEMBER_GROUP3 { get; set; }
        public virtual ICollection<Purchase> PURCHASES1 { get; set; }
        public virtual MEMBER_TYPE MEMBER_TYPE2 { get; set; }
        public virtual VIDEO_PUBLISH VIDEO_PUBLISH3 { get; set; }
        public virtual PARTNER PARTNER2 { get; set; }
        public virtual ICollection<NOTIFICATION_SUBSCRIPTIONS> NOTIFICATION_SUBSCRIPTIONS { get; set; }
        public virtual ICollection<MEMBER_FAVORITES> MEMBER_FAVORITES1 { get; set; }
        public virtual ICollection<Purchase> PURCHASES2 { get; set; }
        public virtual ICollection<NOTIFICATION_SUBSCRIPTIONS> NOTIFICATION_SUBSCRIPTIONS1 { get; set; }
        public virtual ICollection<MEMBER_TRACKED_ENTRANTS> MEMBER_TRACKED_ENTRANTS1 { get; set; }
    }
}
