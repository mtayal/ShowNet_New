using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class CIRCUIT_RELATIONSHIPSMap : EntityTypeConfiguration<CIRCUIT_RELATIONSHIPS>
    {
        public CIRCUIT_RELATIONSHIPSMap()
        {
            // Primary Key
            this.HasKey(t => t.CIRCUIT_RELATIONSHIP_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CIRCUIT_RELATIONSHIPS");
            this.Property(t => t.CIRCUIT_RELATIONSHIP_ID).HasColumnName("CIRCUIT_RELATIONSHIP_ID");
            this.Property(t => t.CIRCUIT_ID).HasColumnName("CIRCUIT_ID");
            this.Property(t => t.HORSE_SHOW_ID).HasColumnName("HORSE_SHOW_ID");

            // Relationships
            this.HasOptional(t => t.CIRCUIT)
                .WithMany(t => t.CIRCUIT_RELATIONSHIPS)
                .HasForeignKey(d => d.CIRCUIT_ID);
            this.HasOptional(t => t.CIRCUIT1)
                .WithMany(t => t.CIRCUIT_RELATIONSHIPS1)
                .HasForeignKey(d => d.CIRCUIT_ID);
            this.HasOptional(t => t.HORSE_SHOW)
                .WithMany(t => t.CIRCUIT_RELATIONSHIPS)
                .HasForeignKey(d => d.HORSE_SHOW_ID);
            this.HasOptional(t => t.HORSE_SHOW1)
                .WithMany(t => t.CIRCUIT_RELATIONSHIPS1)
                .HasForeignKey(d => d.HORSE_SHOW_ID);

        }
    }
}
