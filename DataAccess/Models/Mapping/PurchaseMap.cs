using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PurchaseMap : EntityTypeConfiguration<Purchase>
    {
        public PurchaseMap()
        {
            // Primary Key
            this.HasKey(t => t.PurchaseID);

            // Properties
            this.Property(t => t.Notes)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PURCHASES");
            this.Property(t => t.PurchaseID).HasColumnName("PurchaseID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.IsGUIVisible).HasColumnName("IsGUIVisible");
            this.Property(t => t.CircuitID).HasColumnName("CircuitID");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.AmountPaid).HasColumnName("AmountPaid");
            this.Property(t => t.IncludeFromProduct).HasColumnName("IncludeFromProduct");
            this.Property(t => t.Expires).HasColumnName("Expires");
            this.Property(t => t.DeliveryDetails).HasColumnName("DeliveryDetails");
            this.Property(t => t.ProductCost).HasColumnName("ProductCost");
            this.Property(t => t.ChannelID).HasColumnName("ChannelID");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.MemberBalance).HasColumnName("MemberBalance");

            // Relationships
            this.HasOptional(t => t.CIRCUIT)
                .WithMany(t => t.PURCHASES)
                .HasForeignKey(d => d.CircuitID);
            this.HasOptional(t => t.CIRCUIT1)
                .WithMany(t => t.PURCHASES1)
                .HasForeignKey(d => d.CircuitID);
            this.HasOptional(t => t.DELIVERY_DETAILS1)
                .WithMany(t => t.PURCHASES)
                .HasForeignKey(d => d.DeliveryDetails);
            this.HasOptional(t => t.HORSE_SHOW)
                .WithMany(t => t.PURCHASES)
                .HasForeignKey(d => d.HorseShowID);
            this.HasOptional(t => t.Medium)
                .WithMany(t => t.PURCHASES)
                .HasForeignKey(d => d.MediaID);
            this.HasOptional(t => t.Medium1)
                .WithMany(t => t.PURCHASES1)
                .HasForeignKey(d => d.MediaID);
            this.HasOptional(t => t.Medium2)
                .WithMany(t => t.PURCHASES2)
                .HasForeignKey(d => d.MediaID);
            this.HasRequired(t => t.MEMBER_DETAILS)
                .WithMany(t => t.PURCHASES)
                .HasForeignKey(d => d.MemberID);
            this.HasRequired(t => t.MEMBER_DETAILS1)
                .WithMany(t => t.PURCHASES1)
                .HasForeignKey(d => d.MemberID);
            this.HasRequired(t => t.MEMBER_DETAILS2)
                .WithMany(t => t.PURCHASES2)
                .HasForeignKey(d => d.MemberID);

        }
    }
}
