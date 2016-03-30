using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class AVAILABLE_PURCHASE_BALANCEMap : EntityTypeConfiguration<AVAILABLE_PURCHASE_BALANCE>
    {
        public AVAILABLE_PURCHASE_BALANCEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("AVAILABLE_PURCHASE_BALANCE");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
        }
    }
}
