using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIEW_STREAMING_PURCHASEMap : EntityTypeConfiguration<VIEW_STREAMING_PURCHASE>
    {
        public VIEW_STREAMING_PURCHASEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PurchaseID, t.MemberID, t.ProductID });

            // Properties
            this.Property(t => t.PurchaseID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MemberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VIEW_STREAMING_PURCHASE");
            this.Property(t => t.PurchaseID).HasColumnName("PurchaseID");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.AmountPaid).HasColumnName("AmountPaid");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.ProductCost).HasColumnName("ProductCost");
        }
    }
}
