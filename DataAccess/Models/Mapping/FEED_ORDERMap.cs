using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class FEED_ORDERMap : EntityTypeConfiguration<FEED_ORDER>
    {
        public FEED_ORDERMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.StableWith)
                .HasMaxLength(50);

            this.Property(t => t.Location)
                .HasMaxLength(50);

            this.Property(t => t.StallNumber)
                .HasMaxLength(10);

            this.Property(t => t.WEFNo)
                .HasMaxLength(10);

            this.Property(t => t.SendingTo)
                .HasMaxLength(50);

            this.Property(t => t.Barn)
                .HasMaxLength(50);

            this.Property(t => t.Stall)
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FEED_ORDER");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.StableWith).HasColumnName("StableWith");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.StallNumber).HasColumnName("StallNumber");
            this.Property(t => t.WEFNo).HasColumnName("WEFNo");
            this.Property(t => t.SendingTo).HasColumnName("SendingTo");
            this.Property(t => t.Barn).HasColumnName("Barn");
            this.Property(t => t.Stall).HasColumnName("Stall");
            this.Property(t => t.UserName).HasColumnName("UserName");
        }
    }
}
