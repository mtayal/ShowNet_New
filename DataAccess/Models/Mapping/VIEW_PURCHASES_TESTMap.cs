using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIEW_PURCHASES_TESTMap : EntityTypeConfiguration<VIEW_PURCHASES_TEST>
    {
        public VIEW_PURCHASES_TESTMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PurchaseID, t.ProductID, t.MemberID });

            // Properties
            this.Property(t => t.PurchaseID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MemberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductName)
                .HasMaxLength(255);

            this.Property(t => t.HorseName)
                .HasMaxLength(50);

            this.Property(t => t.ClassID)
                .HasMaxLength(10);

            this.Property(t => t.ClassName)
                .HasMaxLength(60);

            this.Property(t => t.HorseShowName)
                .HasMaxLength(60);

            this.Property(t => t.CIRCUIT_NAME)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("VIEW_PURCHASES_TEST");
            this.Property(t => t.PurchaseID).HasColumnName("PurchaseID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.CircuitID).HasColumnName("CircuitID");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.Expires).HasColumnName("Expires");
            this.Property(t => t.AmountPaid).HasColumnName("AmountPaid");
            this.Property(t => t.IncludeFromProduct).HasColumnName("IncludeFromProduct");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.ProductDescription).HasColumnName("ProductDescription");
            this.Property(t => t.HorseName).HasColumnName("HorseName");
            this.Property(t => t.BackID).HasColumnName("BackID");
            this.Property(t => t.ClassID).HasColumnName("ClassID");
            this.Property(t => t.ClassName).HasColumnName("ClassName");
            this.Property(t => t.HorseShowName).HasColumnName("HorseShowName");
            this.Property(t => t.CIRCUIT_NAME).HasColumnName("CIRCUIT_NAME");
        }
    }
}
