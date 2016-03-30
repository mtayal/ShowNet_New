using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NCAA_ROUNDMap : EntityTypeConfiguration<NCAA_ROUND>
    {
        public NCAA_ROUNDMap()
        {
            // Primary Key
            this.HasKey(t => t.RoundID);

            // Properties
            this.Property(t => t.HorseName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("NCAA_ROUND");
            this.Property(t => t.RoundID).HasColumnName("RoundID");
            this.Property(t => t.Team1Entrant).HasColumnName("Team1Entrant");
            this.Property(t => t.Team2Entrant).HasColumnName("Team2Entrant");
            this.Property(t => t.HorseName).HasColumnName("HorseName");
            this.Property(t => t.Team1Score).HasColumnName("Team1Score");
            this.Property(t => t.Team2Score).HasColumnName("Team2Score");
            this.Property(t => t.OrderIndex).HasColumnName("OrderIndex");
            this.Property(t => t.Bracket).HasColumnName("Bracket");

            // Relationships
            this.HasOptional(t => t.NCAA_BRACKET)
                .WithMany(t => t.NCAA_ROUND)
                .HasForeignKey(d => d.Bracket);
            this.HasOptional(t => t.NCAA_BRACKET1)
                .WithMany(t => t.NCAA_ROUND1)
                .HasForeignKey(d => d.Bracket);
            this.HasOptional(t => t.NCAA_ENTRANT)
                .WithMany(t => t.NCAA_ROUND)
                .HasForeignKey(d => d.Team1Entrant);
            this.HasOptional(t => t.NCAA_ENTRANT1)
                .WithMany(t => t.NCAA_ROUND1)
                .HasForeignKey(d => d.Team2Entrant);
            this.HasOptional(t => t.NCAA_ENTRANT2)
                .WithMany(t => t.NCAA_ROUND2)
                .HasForeignKey(d => d.Team2Entrant);
            this.HasOptional(t => t.NCAA_ENTRANT3)
                .WithMany(t => t.NCAA_ROUND3)
                .HasForeignKey(d => d.Team1Entrant);

        }
    }
}
