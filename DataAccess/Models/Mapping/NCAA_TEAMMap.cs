using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NCAA_TEAMMap : EntityTypeConfiguration<NCAA_TEAM>
    {
        public NCAA_TEAMMap()
        {
            // Primary Key
            this.HasKey(t => t.TeamID);

            // Properties
            this.Property(t => t.TeamName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("NCAA_TEAM");
            this.Property(t => t.TeamID).HasColumnName("TeamID");
            this.Property(t => t.Seeding).HasColumnName("Seeding");
            this.Property(t => t.TeamName).HasColumnName("TeamName");
            this.Property(t => t.Schedule).HasColumnName("Schedule");

            // Relationships
            this.HasOptional(t => t.NCAA_SCHEUDLE)
                .WithMany(t => t.NCAA_TEAM)
                .HasForeignKey(d => d.Schedule);
            this.HasOptional(t => t.NCAA_SCHEUDLE1)
                .WithMany(t => t.NCAA_TEAM1)
                .HasForeignKey(d => d.Schedule);

        }
    }
}
