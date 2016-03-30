using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIEW_MOBILE_SHOW_PURCHASEMap : EntityTypeConfiguration<VIEW_MOBILE_SHOW_PURCHASE>
    {
        public VIEW_MOBILE_SHOW_PURCHASEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PurchaseID, t.MemberID, t.HorseShowName, t.StartDate, t.ProductID });

            // Properties
            this.Property(t => t.PurchaseID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.MemberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HorseShowName)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VIEW_MOBILE_SHOW_PURCHASE");
            this.Property(t => t.PurchaseID).HasColumnName("PurchaseID");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.HorseShowName).HasColumnName("HorseShowName");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.AmountPaid).HasColumnName("AmountPaid");
        }
    }
}
