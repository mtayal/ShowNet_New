using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIEW_MEDIA_FAVOURITESMap : EntityTypeConfiguration<VIEW_MEDIA_FAVOURITES>
    {
        public VIEW_MEDIA_FAVOURITESMap()
        {
            // Primary Key
            this.HasKey(t => new { t.HorseName, t.Trainer, t.ClassID, t.HorseShowName, t.HorseShowID, t.BackID, t.MediaID, t.PurchasesMemberID });

            // Properties
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

            this.Property(t => t.HorseShowID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BackID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MediaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PurchasesMemberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VIEW_MEDIA_FAVOURITES");
            this.Property(t => t.ListID).HasColumnName("ListID");
            this.Property(t => t.RiderName).HasColumnName("RiderName");
            this.Property(t => t.HorseName).HasColumnName("HorseName");
            this.Property(t => t.Trainer).HasColumnName("Trainer");
            this.Property(t => t.HasIPhoneMedia).HasColumnName("HasIPhoneMedia");
            this.Property(t => t.ClassName).HasColumnName("ClassName");
            this.Property(t => t.ClassID).HasColumnName("ClassID");
            this.Property(t => t.HorseShowName).HasColumnName("HorseShowName");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.BackID).HasColumnName("BackID");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
            this.Property(t => t.PurchasesMemberID).HasColumnName("PurchasesMemberID");
            this.Property(t => t.FavouritesMemberID).HasColumnName("FavouritesMemberID");
        }
    }
}
