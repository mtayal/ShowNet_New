using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PRODUCT_TOKENMap : EntityTypeConfiguration<PRODUCT_TOKEN>
    {
        public PRODUCT_TOKENMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductTokenID);

            // Properties
            this.Property(t => t.Token)
                .HasMaxLength(255);

            this.Property(t => t.Email)
                .HasMaxLength(255);

            this.Property(t => t.IPAddress)
                .HasMaxLength(255);

            this.Property(t => t.FactoryName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PRODUCT_TOKEN");
            this.Property(t => t.ProductTokenID).HasColumnName("ProductTokenID");
            this.Property(t => t.Token).HasColumnName("Token");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.IPAddress).HasColumnName("IPAddress");
            this.Property(t => t.Expires).HasColumnName("Expires");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.FactoryName).HasColumnName("FactoryName");
            this.Property(t => t.FactoryKey).HasColumnName("FactoryKey");
        }
    }
}
