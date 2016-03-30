using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class LAST_UPDATEMap : EntityTypeConfiguration<LAST_UPDATE>
    {
        public LAST_UPDATEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UpdateID, t.ID });

            // Properties
            this.Property(t => t.UpdateID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("LAST_UPDATE");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
