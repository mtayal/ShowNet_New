using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIEW_DASHBOARD_MEDIAMap : EntityTypeConfiguration<VIEW_DASHBOARD_MEDIA>
    {
        public VIEW_DASHBOARD_MEDIAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MediaID, t.ClassID, t.HorseName, t.BackID, t.HorseShowID, t.FileName, t.HasWMVAzure });

            // Properties
            this.Property(t => t.MediaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ClassID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ClassName)
                .HasMaxLength(60);

            this.Property(t => t.HorseName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BackID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HorseShowID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Folder)
                .HasMaxLength(200);

            this.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.AzureBlobLocation)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("VIEW_DASHBOARD_MEDIA");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
            this.Property(t => t.ClassID).HasColumnName("ClassID");
            this.Property(t => t.ClassName).HasColumnName("ClassName");
            this.Property(t => t.PurchaseID).HasColumnName("PurchaseID");
            this.Property(t => t.HorseName).HasColumnName("HorseName");
            this.Property(t => t.BackID).HasColumnName("BackID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.Folder).HasColumnName("Folder");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.IncludeFromProduct).HasColumnName("IncludeFromProduct");
            this.Property(t => t.AzureBlobLocation).HasColumnName("AzureBlobLocation");
            this.Property(t => t.FileGuid).HasColumnName("FileGuid");
            this.Property(t => t.MediaType).HasColumnName("MediaType");
            this.Property(t => t.HasFLVAzure).HasColumnName("HasFLVAzure");
            this.Property(t => t.HasWMVAzure).HasColumnName("HasWMVAzure");
            this.Property(t => t.HasMP4Azure).HasColumnName("HasMP4Azure");
        }
    }
}
