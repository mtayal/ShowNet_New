using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NCAA_MODESMap : EntityTypeConfiguration<NCAA_MODES>
    {
        public NCAA_MODESMap()
        {
            // Primary Key
            this.HasKey(t => t.ModeID);

            // Properties
            this.Property(t => t.ModeName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("NCAA_MODES");
            this.Property(t => t.ModeID).HasColumnName("ModeID");
            this.Property(t => t.ModeName).HasColumnName("ModeName");
        }
    }
}
