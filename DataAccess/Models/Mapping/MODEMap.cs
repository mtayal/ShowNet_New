using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class MODEMap : EntityTypeConfiguration<MODE>
    {
        public MODEMap()
        {
            // Primary Key
            this.HasKey(t => t.ModeID);

            // Properties
            this.Property(t => t.ModeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ModeName)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("MODE");
            this.Property(t => t.ModeID).HasColumnName("ModeID");
            this.Property(t => t.ModeName).HasColumnName("ModeName");
            this.Property(t => t.OrderIndex).HasColumnName("OrderIndex");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");
        }
    }
}
