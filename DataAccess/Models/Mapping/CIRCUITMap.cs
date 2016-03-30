using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class CIRCUITMap : EntityTypeConfiguration<CIRCUIT>
    {
        public CIRCUITMap()
        {
            // Primary Key
            this.HasKey(t => t.CIRCUIT_ID);

            // Properties
            this.Property(t => t.CIRCUIT_NAME)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("CIRCUIT");
            this.Property(t => t.CIRCUIT_ID).HasColumnName("CIRCUIT_ID");
            this.Property(t => t.CIRCUIT_NAME).HasColumnName("CIRCUIT_NAME");
            this.Property(t => t.CIRCUIT_DESCRIPTION).HasColumnName("CIRCUIT_DESCRIPTION");
            this.Property(t => t.CIRCUIT_PRICE).HasColumnName("CIRCUIT_PRICE");
            this.Property(t => t.END_DATE).HasColumnName("END_DATE");
        }
    }
}
