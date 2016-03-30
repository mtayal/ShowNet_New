using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIEW_ENTRANT_MEDIAMap : EntityTypeConfiguration<VIEW_ENTRANT_MEDIA>
    {
        public VIEW_ENTRANT_MEDIAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BackID, t.HorseShowID, t.HorseName, t.ClassID, t.MediaID });

            // Properties
            this.Property(t => t.BackID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HorseShowID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HorseName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ClassName)
                .HasMaxLength(60);

            this.Property(t => t.ClassID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MediaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VIEW_ENTRANT_MEDIA");
            this.Property(t => t.BackID).HasColumnName("BackID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.HorseName).HasColumnName("HorseName");
            this.Property(t => t.ClassName).HasColumnName("ClassName");
            this.Property(t => t.ClassID).HasColumnName("ClassID");
            this.Property(t => t.ListID).HasColumnName("ListID");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
        }
    }
}
