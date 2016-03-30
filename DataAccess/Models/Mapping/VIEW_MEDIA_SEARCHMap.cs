using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIEW_MEDIA_SEARCHMap : EntityTypeConfiguration<VIEW_MEDIA_SEARCH>
    {
        public VIEW_MEDIA_SEARCHMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BackID, t.HorseName, t.Owner1, t.HorseShowID, t.HorseShowName, t.ListID, t.MediaID, t.ClassID, t.StartDate, t.EndDate, t.Filename, t.ScheduleID });

            // Properties
            this.Property(t => t.BackID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HorseName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Owner1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Rider)
                .HasMaxLength(50);

            this.Property(t => t.HorseShowID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HorseShowName)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ListID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RiderName)
                .HasMaxLength(50);

            this.Property(t => t.MediaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ClassID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ClassName)
                .HasMaxLength(60);

            this.Property(t => t.AzureBlobLocation)
                .HasMaxLength(255);

            this.Property(t => t.Folder)
                .HasMaxLength(200);

            this.Property(t => t.Filename)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ScheduleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VIEW_MEDIA_SEARCH");
            this.Property(t => t.BackID).HasColumnName("BackID");
            this.Property(t => t.HorseName).HasColumnName("HorseName");
            this.Property(t => t.Owner1).HasColumnName("Owner1");
            this.Property(t => t.Rider).HasColumnName("Rider");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.HorseShowName).HasColumnName("HorseShowName");
            this.Property(t => t.ListID).HasColumnName("ListID");
            this.Property(t => t.RiderName).HasColumnName("RiderName");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
            this.Property(t => t.ClassID).HasColumnName("ClassID");
            this.Property(t => t.ClassName).HasColumnName("ClassName");
            this.Property(t => t.HasIPhoneMedia).HasColumnName("HasIPhoneMedia");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.HasThumbnails).HasColumnName("HasThumbnails");
            this.Property(t => t.HasMP4Azure).HasColumnName("HasMP4Azure");
            this.Property(t => t.AzureBlobLocation).HasColumnName("AzureBlobLocation");
            this.Property(t => t.MediaType).HasColumnName("MediaType");
            this.Property(t => t.FileGUID).HasColumnName("FileGUID");
            this.Property(t => t.Folder).HasColumnName("Folder");
            this.Property(t => t.Filename).HasColumnName("Filename");
            this.Property(t => t.HasFLVAzure).HasColumnName("HasFLVAzure");
            this.Property(t => t.ScheduleID).HasColumnName("ScheduleID");
        }
    }
}
