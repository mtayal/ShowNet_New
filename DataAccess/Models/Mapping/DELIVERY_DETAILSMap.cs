using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class DELIVERY_DETAILSMap : EntityTypeConfiguration<DELIVERY_DETAILS>
    {
        public DELIVERY_DETAILSMap()
        {
            // Primary Key
            this.HasKey(t => t.DeliveryDetailsID);

            // Properties
            this.Property(t => t.Salutation)
                .HasMaxLength(255);

            this.Property(t => t.FirstName)
                .HasMaxLength(255);

            this.Property(t => t.LastName)
                .HasMaxLength(255);

            this.Property(t => t.Address1)
                .HasMaxLength(255);

            this.Property(t => t.Address2)
                .HasMaxLength(255);

            this.Property(t => t.City)
                .HasMaxLength(255);

            this.Property(t => t.State)
                .HasMaxLength(255);

            this.Property(t => t.Zip)
                .HasMaxLength(255);

            this.Property(t => t.Instructions)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("DELIVERY_DETAILS");
            this.Property(t => t.DeliveryDetailsID).HasColumnName("DeliveryDetailsID");
            this.Property(t => t.Salutation).HasColumnName("Salutation");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.Instructions).HasColumnName("Instructions");
            this.Property(t => t.MemberDetails).HasColumnName("MemberDetails");
            this.Property(t => t.Purchase).HasColumnName("Purchase");

            // Relationships
            this.HasRequired(t => t.Purchase1)
                .WithMany(t => t.DELIVERY_DETAILS)
                .HasForeignKey(d => d.Purchase);
            this.HasRequired(t => t.MEMBER_DETAILS)
                .WithMany(t => t.DELIVERY_DETAILS)
                .HasForeignKey(d => d.MemberDetails);

        }
    }
}
