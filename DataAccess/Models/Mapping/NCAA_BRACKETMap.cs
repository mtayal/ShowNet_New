using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NCAA_BRACKETMap : EntityTypeConfiguration<NCAA_BRACKET>
    {
        public NCAA_BRACKETMap()
        {
            // Primary Key
            this.HasKey(t => t.BracketID);

            // Properties
            this.Property(t => t.BracketName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("NCAA_BRACKET");
            this.Property(t => t.BracketID).HasColumnName("BracketID");
            this.Property(t => t.Team1).HasColumnName("Team1");
            this.Property(t => t.Team2).HasColumnName("Team2");
            this.Property(t => t.Schedule).HasColumnName("Schedule");
            this.Property(t => t.WinnerBracket).HasColumnName("WinnerBracket");
            this.Property(t => t.LoserBracket).HasColumnName("LoserBracket");
            this.Property(t => t.IsComplete).HasColumnName("IsComplete");
            this.Property(t => t.Team1Score).HasColumnName("Team1Score");
            this.Property(t => t.Team2Score).HasColumnName("Team2Score");
            this.Property(t => t.WinningTeamID).HasColumnName("WinningTeamID");
            this.Property(t => t.LosingTeamID).HasColumnName("LosingTeamID");
            this.Property(t => t.BracketName).HasColumnName("BracketName");
            this.Property(t => t.BracketIdentifier).HasColumnName("BracketIdentifier");

            // Relationships
            this.HasOptional(t => t.NCAA_SCHEUDLE)
                .WithMany(t => t.NCAA_BRACKET)
                .HasForeignKey(d => d.Schedule);
            this.HasOptional(t => t.NCAA_TEAM)
                .WithMany(t => t.NCAA_BRACKET)
                .HasForeignKey(d => d.Team1);
            this.HasOptional(t => t.NCAA_TEAM1)
                .WithMany(t => t.NCAA_BRACKET1)
                .HasForeignKey(d => d.Team2);
            this.HasOptional(t => t.NCAA_SCHEUDLE1)
                .WithMany(t => t.NCAA_BRACKET1)
                .HasForeignKey(d => d.Schedule);
            this.HasOptional(t => t.NCAA_TEAM2)
                .WithMany(t => t.NCAA_BRACKET2)
                .HasForeignKey(d => d.Team2);
            this.HasOptional(t => t.NCAA_TEAM3)
                .WithMany(t => t.NCAA_BRACKET3)
                .HasForeignKey(d => d.Team1);

        }
    }
}
