using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class FEED_ORDER_ITEMMap : EntityTypeConfiguration<FEED_ORDER_ITEM>
    {
        public FEED_ORDER_ITEMMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemID);

            // Properties
            this.Property(t => t.Desc)
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FEED_ORDER_ITEM");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.Desc).HasColumnName("Desc");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
        }
    }
}
