using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NCAA_ENTRANTMap : EntityTypeConfiguration<NCAA_ENTRANT>
    {
        public NCAA_ENTRANTMap()
        {
            // Primary Key
            this.HasKey(t => t.EntrantID);

            // Properties
            this.Property(t => t.HorseName)
                .HasMaxLength(255);

            this.Property(t => t.Trainer)
                .HasMaxLength(255);

            this.Property(t => t.Owner1)
                .HasMaxLength(255);

            this.Property(t => t.Owner2)
                .HasMaxLength(255);

            this.Property(t => t.Rider)
                .HasMaxLength(255);

            this.Property(t => t.RiderAddr)
                .HasMaxLength(255);

            this.Property(t => t.Owner1Addr)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("NCAA_ENTRANT");
            this.Property(t => t.EntrantID).HasColumnName("EntrantID");
            this.Property(t => t.BackID).HasColumnName("BackID");
            this.Property(t => t.HorseName).HasColumnName("HorseName");
            this.Property(t => t.Trainer).HasColumnName("Trainer");
            this.Property(t => t.Owner1).HasColumnName("Owner1");
            this.Property(t => t.Owner2).HasColumnName("Owner2");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");
            this.Property(t => t.Rider).HasColumnName("Rider");
            this.Property(t => t.RiderAddr).HasColumnName("RiderAddr");
            this.Property(t => t.Owner1Addr).HasColumnName("Owner1Addr");
            this.Property(t => t.Team).HasColumnName("Team");

            // Relationships
            this.HasOptional(t => t.NCAA_TEAM)
                .WithMany(t => t.NCAA_ENTRANT)
                .HasForeignKey(d => d.Team);
            this.HasOptional(t => t.NCAA_TEAM1)
                .WithMany(t => t.NCAA_ENTRANT1)
                .HasForeignKey(d => d.Team);

        }
    }
}
