using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class View_SearchAutoCompleteMap : EntityTypeConfiguration<View_SearchAutoComplete>
    {
        public View_SearchAutoCompleteMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BackID, t.HorseName, t.Owner1, t.HorseShowID, t.HorseShowName, t.ListID, t.MediaID });

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

            // Table & Column Mappings
            this.ToTable("View_SearchAutoComplete");
            this.Property(t => t.BackID).HasColumnName("BackID");
            this.Property(t => t.HorseName).HasColumnName("HorseName");
            this.Property(t => t.Owner1).HasColumnName("Owner1");
            this.Property(t => t.Rider).HasColumnName("Rider");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.HorseShowName).HasColumnName("HorseShowName");
            this.Property(t => t.ListID).HasColumnName("ListID");
            this.Property(t => t.RiderName).HasColumnName("RiderName");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
        }
    }
}
