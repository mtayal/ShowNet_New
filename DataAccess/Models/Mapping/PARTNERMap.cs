using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PARTNERMap : EntityTypeConfiguration<PARTNER>
    {
        public PARTNERMap()
        {
            // Primary Key
            this.HasKey(t => t.PartnerID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(255);

            this.Property(t => t.Url)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PARTNER");
            this.Property(t => t.PartnerID).HasColumnName("PartnerID");
            this.Property(t => t.Guid).HasColumnName("Guid");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Url).HasColumnName("Url");
        }
    }
}
