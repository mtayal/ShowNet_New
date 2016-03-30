using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NCAA_SCHEUDLEMap : EntityTypeConfiguration<NCAA_SCHEUDLE>
    {
        public NCAA_SCHEUDLEMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleID);

            // Properties
            this.Property(t => t.ScheduleName)
                .HasMaxLength(255);

            this.Property(t => t.RingStatus)
                .HasMaxLength(255);

            this.Property(t => t.Comment)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("NCAA_SCHEUDLE");
            this.Property(t => t.ScheduleID).HasColumnName("ScheduleID");
            this.Property(t => t.ScheduleName).HasColumnName("ScheduleName");
            this.Property(t => t.ETA).HasColumnName("ETA");
            this.Property(t => t.RingStatus).HasColumnName("RingStatus");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.Approved).HasColumnName("Approved");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Show).HasColumnName("Show");

            // Relationships
            this.HasOptional(t => t.NCAA_SHOW)
                .WithMany(t => t.NCAA_SCHEUDLE)
                .HasForeignKey(d => d.Show);
            this.HasOptional(t => t.NCAA_SHOW1)
                .WithMany(t => t.NCAA_SCHEUDLE1)
                .HasForeignKey(d => d.Show);

        }
    }
}
