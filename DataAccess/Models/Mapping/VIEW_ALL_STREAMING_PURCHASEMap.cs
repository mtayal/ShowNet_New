using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIEW_ALL_STREAMING_PURCHASEMap : EntityTypeConfiguration<VIEW_ALL_STREAMING_PURCHASE>
    {
        public VIEW_ALL_STREAMING_PURCHASEMap()
        {
            // Primary Key
            this.HasKey(t => t.PurchaseID);

            // Properties
            this.Property(t => t.UserName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("VIEW_ALL_STREAMING_PURCHASE");
            this.Property(t => t.PurchaseID).HasColumnName("PurchaseID");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.AmountPaid).HasColumnName("AmountPaid");
            this.Property(t => t.ProductCost).HasColumnName("ProductCost");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.ChannelID).HasColumnName("ChannelID");
        }
    }
}
