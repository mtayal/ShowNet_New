using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PURCHASE_PROBLEMSMap : EntityTypeConfiguration<PURCHASE_PROBLEMS>
    {
        public PURCHASE_PROBLEMSMap()
        {
            // Primary Key
            this.HasKey(t => t.PurchaseProblemID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PURCHASE_PROBLEMS");
            this.Property(t => t.PurchaseProblemID).HasColumnName("PurchaseProblemID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.Message).HasColumnName("Message");
        }
    }
}
