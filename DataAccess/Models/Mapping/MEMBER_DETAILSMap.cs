using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class MEMBER_DETAILSMap : EntityTypeConfiguration<MEMBER_DETAILS>
    {
        public MEMBER_DETAILSMap()
        {
            // Primary Key
            this.HasKey(t => t.MemberID);

            // Properties
            this.Property(t => t.Salutation)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.FirstName)
                .HasMaxLength(30);

            this.Property(t => t.LastName)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.Address1)
                .IsFixedLength()
                .HasMaxLength(255);

            this.Property(t => t.Address2)
                .IsFixedLength()
                .HasMaxLength(255);

            this.Property(t => t.City)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.State)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.Zip)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Phone)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.Email)
                .IsFixedLength()
                .HasMaxLength(255);

            this.Property(t => t.UserName)
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .HasMaxLength(50);

            this.Property(t => t.PasswordHint)
                .HasMaxLength(50);

            this.Property(t => t.MemberStatus)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.AreaCode)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.sms)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.AlertEmail)
                .HasMaxLength(255);

            this.Property(t => t.iPhoneDeviceGUID)
                .HasMaxLength(64);

            this.Property(t => t.CircuitSalesReportList)
                .HasMaxLength(255);

            this.Property(t => t.ShowSalesReportList)
                .HasMaxLength(255);

            this.Property(t => t.TwitterUsername)
                .HasMaxLength(255);

            this.Property(t => t.TwitterOAuthToken)
                .HasMaxLength(255);

            this.Property(t => t.TwitterOAuthSecret)
                .HasMaxLength(255);

            this.Property(t => t.FacebookUsername)
                .HasMaxLength(255);

            this.Property(t => t.FacebookOAuthToken)
                .HasMaxLength(255);

            this.Property(t => t.FacebookOAuthSecret)
                .HasMaxLength(255);

            this.Property(t => t.BlackBerryDeviceID)
                .HasMaxLength(50);

            this.Property(t => t.iPhoneNotificationGUID)
                .HasMaxLength(255);

            this.Property(t => t.AndroidDeviceGUID)
                .HasMaxLength(1000);

            this.Property(t => t.AndroidNotificationGUID)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("MEMBER_DETAILS");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.Salutation).HasColumnName("Salutation");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.PasswordHint).HasColumnName("PasswordHint");
            this.Property(t => t.DateJoined).HasColumnName("DateJoined");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.MemberStatus).HasColumnName("MemberStatus");
            this.Property(t => t.AreaCode).HasColumnName("AreaCode");
            this.Property(t => t.ExpiryDate).HasColumnName("ExpiryDate");
            this.Property(t => t.sms).HasColumnName("sms");
            this.Property(t => t.MessageNotification).HasColumnName("MessageNotification");
            this.Property(t => t.ActivationGUID).HasColumnName("ActivationGUID");
            this.Property(t => t.AlertEmail).HasColumnName("AlertEmail");
            this.Property(t => t.LastLogin).HasColumnName("LastLogin");
            this.Property(t => t.iPhoneDeviceGUID).HasColumnName("iPhoneDeviceGUID");
            this.Property(t => t.SendPushNotification).HasColumnName("SendPushNotification");
            this.Property(t => t.CircuitSalesReportList).HasColumnName("CircuitSalesReportList");
            this.Property(t => t.ShowSalesReportList).HasColumnName("ShowSalesReportList");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
            this.Property(t => t.IsSalesAdmin).HasColumnName("IsSalesAdmin");
            this.Property(t => t.TwitterUsername).HasColumnName("TwitterUsername");
            this.Property(t => t.TwitterOAuthToken).HasColumnName("TwitterOAuthToken");
            this.Property(t => t.TwitterOAuthSecret).HasColumnName("TwitterOAuthSecret");
            this.Property(t => t.TwitterIsPublic).HasColumnName("TwitterIsPublic");
            this.Property(t => t.FacebookUsername).HasColumnName("FacebookUsername");
            this.Property(t => t.FacebookOAuthToken).HasColumnName("FacebookOAuthToken");
            this.Property(t => t.FacebookOAuthSecret).HasColumnName("FacebookOAuthSecret");
            this.Property(t => t.FacebookIsPublic).HasColumnName("FacebookIsPublic");
            this.Property(t => t.VideoPublish).HasColumnName("VideoPublish");
            this.Property(t => t.BlackBerryDeviceID).HasColumnName("BlackBerryDeviceID");
            this.Property(t => t.iPhoneNotificationGUID).HasColumnName("iPhoneNotificationGUID");
            this.Property(t => t.AndroidDeviceGUID).HasColumnName("AndroidDeviceGUID");
            this.Property(t => t.AndroidNotificationGUID).HasColumnName("AndroidNotificationGUID");
            this.Property(t => t.iPhonePushNotification).HasColumnName("iPhonePushNotification");
            this.Property(t => t.AndroidPushNotification).HasColumnName("AndroidPushNotification");
            this.Property(t => t.BlackBerryPushNotification).HasColumnName("BlackBerryPushNotification");
            this.Property(t => t.TwitterNotification).HasColumnName("TwitterNotification");
            this.Property(t => t.FacebookNotification).HasColumnName("FacebookNotification");
            this.Property(t => t.FacebookProfileId).HasColumnName("FacebookProfileId");
            this.Property(t => t.Partner).HasColumnName("Partner");
            this.Property(t => t.Mode).HasColumnName("Mode");
            this.Property(t => t.DefaultDeliveryDetails).HasColumnName("DefaultDeliveryDetails");
            this.Property(t => t.HasSeenUpgrade).HasColumnName("HasSeenUpgrade");

            // Relationships
            this.HasOptional(t => t.DELIVERY_DETAILS1)
                .WithMany(t => t.MEMBER_DETAILS1)
                .HasForeignKey(d => d.DefaultDeliveryDetails);
            this.HasOptional(t => t.MEMBER_TYPE)
                .WithMany(t => t.MEMBER_DETAILS)
                .HasForeignKey(d => d.TypeID);
            this.HasOptional(t => t.PARTNER1)
                .WithMany(t => t.MEMBER_DETAILS)
                .HasForeignKey(d => d.Partner);
            this.HasOptional(t => t.MEMBER_TYPE1)
                .WithMany(t => t.MEMBER_DETAILS1)
                .HasForeignKey(d => d.TypeID);
            this.HasOptional(t => t.VIDEO_PUBLISH1)
                .WithMany(t => t.MEMBER_DETAILS1)
                .HasForeignKey(d => d.VideoPublish);
            this.HasOptional(t => t.MEMBER_TYPE2)
                .WithMany(t => t.MEMBER_DETAILS2)
                .HasForeignKey(d => d.TypeID);
            this.HasOptional(t => t.VIDEO_PUBLISH3)
                .WithMany(t => t.MEMBER_DETAILS3)
                .HasForeignKey(d => d.VideoPublish);
            this.HasOptional(t => t.PARTNER2)
                .WithMany(t => t.MEMBER_DETAILS1)
                .HasForeignKey(d => d.Partner);

        }
    }
}
