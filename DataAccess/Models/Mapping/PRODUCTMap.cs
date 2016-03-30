using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PRODUCTMap : EntityTypeConfiguration<PRODUCT>
    {
        public PRODUCTMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Properties
            this.Property(t => t.ProductName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PRODUCTS");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.ProductCost).HasColumnName("ProductCost");
            this.Property(t => t.ProductDescription).HasColumnName("ProductDescription");
            this.Property(t => t.IncludedClipDownload).HasColumnName("IncludedClipDownload");
            this.Property(t => t.IncludedOnlineViews).HasColumnName("IncludedOnlineViews");
            this.Property(t => t.IncludedMobileViews).HasColumnName("IncludedMobileViews");
            this.Property(t => t.ExiresAfterMinutes).HasColumnName("ExiresAfterMinutes");
        }
    }
}
