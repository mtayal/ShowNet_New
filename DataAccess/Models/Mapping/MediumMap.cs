using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class MediumMap : EntityTypeConfiguration<Medium>
    {
        public MediumMap()
        {
            // Primary Key
            this.HasKey(t => t.MediaID);

            // Properties
            this.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Extension)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ContentType)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Folder)
                .HasMaxLength(200);

            this.Property(t => t.OriginalFilename)
                .HasMaxLength(255);

            this.Property(t => t.OriginalFolder)
                .HasMaxLength(255);

            this.Property(t => t.IPhoneMediaFilename)
                .HasMaxLength(255);

            this.Property(t => t.FlashMediaFilename)
                .HasMaxLength(255);

            this.Property(t => t.MimeType)
                .HasMaxLength(50);

            this.Property(t => t.WebMMediaFilename)
                .HasMaxLength(255);

            this.Property(t => t.AzureFileType)
                .HasMaxLength(255);

            this.Property(t => t.AzureBlobLocation)
                .HasMaxLength(255);

            this.Property(t => t.PrivatizedMemberIDs)
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("MEDIA");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.Extension).HasColumnName("Extension");
            this.Property(t => t.Size).HasColumnName("Size");
            this.Property(t => t.Width).HasColumnName("Width");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.ContentType).HasColumnName("ContentType");
            this.Property(t => t.Folder).HasColumnName("Folder");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.OriginalFilename).HasColumnName("OriginalFilename");
            this.Property(t => t.OriginalFolder).HasColumnName("OriginalFolder");
            this.Property(t => t.DeferedSave).HasColumnName("DeferedSave");
            this.Property(t => t.ListID).HasColumnName("ListID");
            this.Property(t => t.LengthSeconds).HasColumnName("LengthSeconds");
            this.Property(t => t.HasIPhoneMedia).HasColumnName("HasIPhoneMedia");
            this.Property(t => t.HasThumbnails).HasColumnName("HasThumbnails");
            this.Property(t => t.VideoPublish).HasColumnName("VideoPublish");
            this.Property(t => t.IsPublic).HasColumnName("IsPublic");
            this.Property(t => t.IsPartnerAvailable).HasColumnName("IsPartnerAvailable");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.FileGuid).HasColumnName("FileGuid");
            this.Property(t => t.HasFlashMedia).HasColumnName("HasFlashMedia");
            this.Property(t => t.IPhoneMediaFilename).HasColumnName("IPhoneMediaFilename");
            this.Property(t => t.FlashMediaFilename).HasColumnName("FlashMediaFilename");
            this.Property(t => t.HasFLVMedia).HasColumnName("HasFLVMedia");
            this.Property(t => t.MediaType).HasColumnName("MediaType");
            this.Property(t => t.MimeType).HasColumnName("MimeType");
            this.Property(t => t.QualityScale).HasColumnName("QualityScale");
            this.Property(t => t.ImageCount).HasColumnName("ImageCount");
            this.Property(t => t.HasWebMMedia).HasColumnName("HasWebMMedia");
            this.Property(t => t.WebMMediaFilename).HasColumnName("WebMMediaFilename");
            this.Property(t => t.HasAzure).HasColumnName("HasAzure");
            this.Property(t => t.AzureFileType).HasColumnName("AzureFileType");
            this.Property(t => t.AzureBlobLocation).HasColumnName("AzureBlobLocation");
            this.Property(t => t.HasFLVAzure).HasColumnName("HasFLVAzure");
            this.Property(t => t.HasMP4Azure).HasColumnName("HasMP4Azure");
            this.Property(t => t.HasImagesAzure).HasColumnName("HasImagesAzure");
            this.Property(t => t.HasWMVAzure).HasColumnName("HasWMVAzure");
            this.Property(t => t.PlaybackMediaLocation).HasColumnName("PlaybackMediaLocation");
            this.Property(t => t.PrivatizedMemberIDs).HasColumnName("PrivatizedMemberIDs");

            // Relationships
            this.HasOptional(t => t.VIDEO_PUBLISH1)
                .WithMany(t => t.MEDIA1)
                .HasForeignKey(d => d.VideoPublish);
            this.HasOptional(t => t.VIDEO_PUBLISH3)
                .WithMany(t => t.MEDIA2)
                .HasForeignKey(d => d.VideoPublish);

        }
    }
}
