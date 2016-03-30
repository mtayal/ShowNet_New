using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIEW_MOBILE_MEDIA_SHOW_PURCHASE_EXPIRESMap : EntityTypeConfiguration<VIEW_MOBILE_MEDIA_SHOW_PURCHASE_EXPIRES>
    {
        public VIEW_MOBILE_MEDIA_SHOW_PURCHASE_EXPIRESMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PurchaseID, t.MediaID, t.MemberID, t.HorseName, t.Trainer, t.ClassID, t.HorseShowName, t.ProductID, t.HorseShowID, t.BackID, t.FileName, t.HasWMVAzure, t.ScheduleID });

            // Properties
            this.Property(t => t.PurchaseID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MediaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MemberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RiderName)
                .HasMaxLength(50);

            this.Property(t => t.HorseName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Trainer)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ClassName)
                .HasMaxLength(60);

            this.Property(t => t.ClassID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.HorseShowName)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HorseShowID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BackID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Folder)
                .HasMaxLength(200);

            this.Property(t => t.AzureBlobLocation)
                .HasMaxLength(255);

            this.Property(t => t.ScheduleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PrivatizedMemberIDs)
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("VIEW_MOBILE_MEDIA_SHOW_PURCHASE_EXPIRES");
            this.Property(t => t.PurchaseID).HasColumnName("PurchaseID");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.ListID).HasColumnName("ListID");
            this.Property(t => t.RiderName).HasColumnName("RiderName");
            this.Property(t => t.HorseName).HasColumnName("HorseName");
            this.Property(t => t.Trainer).HasColumnName("Trainer");
            this.Property(t => t.HasIPhoneMedia).HasColumnName("HasIPhoneMedia");
            this.Property(t => t.ClassName).HasColumnName("ClassName");
            this.Property(t => t.ClassID).HasColumnName("ClassID");
            this.Property(t => t.HorseShowName).HasColumnName("HorseShowName");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.BackID).HasColumnName("BackID");
            this.Property(t => t.AmountPaid).HasColumnName("AmountPaid");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.Folder).HasColumnName("Folder");
            this.Property(t => t.IncludeFromProduct).HasColumnName("IncludeFromProduct");
            this.Property(t => t.AzureBlobLocation).HasColumnName("AzureBlobLocation");
            this.Property(t => t.FileGuid).HasColumnName("FileGuid");
            this.Property(t => t.MediaType).HasColumnName("MediaType");
            this.Property(t => t.HasFLVAzure).HasColumnName("HasFLVAzure");
            this.Property(t => t.HasWMVAzure).HasColumnName("HasWMVAzure");
            this.Property(t => t.HasMP4Azure).HasColumnName("HasMP4Azure");
            this.Property(t => t.ScheduleID).HasColumnName("ScheduleID");
            this.Property(t => t.PrivatizedMemberIDs).HasColumnName("PrivatizedMemberIDs");
        }
    }
}
