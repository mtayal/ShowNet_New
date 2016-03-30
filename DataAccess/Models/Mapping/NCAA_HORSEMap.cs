using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NCAA_HORSEMap : EntityTypeConfiguration<NCAA_HORSE>
    {
        public NCAA_HORSEMap()
        {
            // Primary Key
            this.HasKey(t => t.HorseID);

            // Properties
            this.Property(t => t.HorseName)
                .HasMaxLength(255);

            this.Property(t => t.Trainer)
                .HasMaxLength(255);

            this.Property(t => t.Owner1)
                .HasMaxLength(255);

            this.Property(t => t.Owner2)
                .HasMaxLength(255);

            this.Property(t => t.Owner1Addr)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("NCAA_HORSE");
            this.Property(t => t.HorseID).HasColumnName("HorseID");
            this.Property(t => t.HorseName).HasColumnName("HorseName");
            this.Property(t => t.Trainer).HasColumnName("Trainer");
            this.Property(t => t.Owner1).HasColumnName("Owner1");
            this.Property(t => t.Owner2).HasColumnName("Owner2");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");
            this.Property(t => t.Owner1Addr).HasColumnName("Owner1Addr");
            this.Property(t => t.Bracket).HasColumnName("Bracket");

            // Relationships
            this.HasOptional(t => t.NCAA_BRACKET)
                .WithMany(t => t.NCAA_HORSE)
                .HasForeignKey(d => d.Bracket);
            this.HasOptional(t => t.NCAA_BRACKET1)
                .WithMany(t => t.NCAA_HORSE1)
                .HasForeignKey(d => d.Bracket);

        }
    }
}
