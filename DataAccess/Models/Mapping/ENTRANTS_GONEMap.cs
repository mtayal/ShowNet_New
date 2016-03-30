using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ENTRANTS_GONEMap : EntityTypeConfiguration<ENTRANTS_GONE>
    {
        public ENTRANTS_GONEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.GoneEntrantID, t.ListID });

            // Properties
            this.Property(t => t.GoneEntrantID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ListID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ENTRANTS_GONE");
            this.Property(t => t.GoneEntrantID).HasColumnName("GoneEntrantID");
            this.Property(t => t.ListID).HasColumnName("ListID");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.ScheduleID).HasColumnName("ScheduleID");
        }
    }
}
