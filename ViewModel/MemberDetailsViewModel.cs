using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

using System.Data.Entity;
using System.Globalization;
//using System.Web.Security;

namespace ViewModel
{
    public class MemberDetailsViewModel
    {

        public int MemberID { get; set; }
        public string Salutation { get; set; }
        [Required(ErrorMessage="*")]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "*")]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "*")]
        [MaxLength(255)]
        public string Address1 { get; set; }
        [MaxLength(255)]
        public string Address2 { get; set; }
        [Required(ErrorMessage = "*")]
        [MaxLength(30)]
        public string City { get; set; }
        [Required(ErrorMessage = "*")]
        [MaxLength(20)]
        public string State { get; set; }
        [Required(ErrorMessage = "*")]
        [MaxLength(10)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "*")]
        public string Zip { get; set; }
        [MaxLength(20)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "*")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "*")]
        [MaxLength(255)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Email is not valid")] 
        public string Email { get; set; }
        [Required(ErrorMessage = "*")]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "*")]
        [MaxLength(50)]
        public string Password { get; set; }
        [Required(ErrorMessage = "*")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "*")]
        [MaxLength(50)]
        public string PasswordHint { get; set; }

        //public Nullable<System.DateTime> DateJoined { get; set; }
        //public Nullable<int> TypeID { get; set; }
        //public string MemberStatus { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "*")]
        [MaxLength(4)]
        public string AreaCode { get; set; }

        public IEnumerable<MemberGroupViewModel> MemberGroupList { get; set; }
        //public Nullable<System.DateTime> ExpiryDate { get; set; }
        //public string sms { get; set; }
        //public Nullable<bool> MessageNotification { get; set; }
        //public Nullable<System.Guid> ActivationGUID { get; set; }
        //public string AlertEmail { get; set; }
        //public Nullable<System.DateTime> LastLogin { get; set; }
        //public string iPhoneDeviceGUID { get; set; }
        //public Nullable<bool> SendPushNotification { get; set; }
        //public string CircuitSalesReportList { get; set; }
        //public string ShowSalesReportList { get; set; }
        //public Nullable<bool> IsAdmin { get; set; }
        //public Nullable<bool> IsSalesAdmin { get; set; }
        //public string TwitterUsername { get; set; }
        //public string TwitterOAuthToken { get; set; }
        //public string TwitterOAuthSecret { get; set; }
        //public Nullable<bool> TwitterIsPublic { get; set; }
        //public string FacebookUsername { get; set; }
        //public string FacebookOAuthToken { get; set; }
        //public string FacebookOAuthSecret { get; set; }
        //public Nullable<bool> FacebookIsPublic { get; set; }
        //public Nullable<int> VideoPublish { get; set; }
        //public string BlackBerryDeviceID { get; set; }
        //public string iPhoneNotificationGUID { get; set; }
        //public string AndroidDeviceGUID { get; set; }
        //public string AndroidNotificationGUID { get; set; }
        //public Nullable<bool> iPhonePushNotification { get; set; }
        //public Nullable<bool> AndroidPushNotification { get; set; }
        //public Nullable<bool> BlackBerryPushNotification { get; set; }
        //public Nullable<bool> TwitterNotification { get; set; }
        //public Nullable<bool> FacebookNotification { get; set; }
        //public Nullable<long> FacebookProfileId { get; set; }
        //public Nullable<int> Partner { get; set; }
        public Nullable<int> Mode { get; set; }
        //public Nullable<int> DefaultDeliveryDetails { get; set; }
        //public Nullable<bool> HasSeenUpgrade { get; set; }
    }
}
