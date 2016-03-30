using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIDEO_STREAMMap : EntityTypeConfiguration<VIDEO_STREAM>
    {
        public VIDEO_STREAMMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.StreamUri)
                .HasMaxLength(1000);

            this.Property(t => t.Stream)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("VIDEO_STREAM");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ScheduledStart).HasColumnName("ScheduledStart");
            this.Property(t => t.ScheduledStop).HasColumnName("ScheduledStop");
            this.Property(t => t.StreamUri).HasColumnName("StreamUri");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.IsFree).HasColumnName("IsFree");
            this.Property(t => t.HorseShow).HasColumnName("HorseShow");
            this.Property(t => t.ShowDay).HasColumnName("ShowDay");
            this.Property(t => t.Schedule).HasColumnName("Schedule");
            this.Property(t => t.IsLive).HasColumnName("IsLive");
            this.Property(t => t.Width).HasColumnName("Width");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Stream).HasColumnName("Stream");

            // Relationships
            this.HasOptional(t => t.HORSE_SHOW)
                .WithMany(t => t.VIDEO_STREAM)
                .HasForeignKey(d => d.HorseShow);
            this.HasOptional(t => t.HORSE_SHOW1)
                .WithMany(t => t.VIDEO_STREAM1)
                .HasForeignKey(d => d.HorseShow);
            this.HasOptional(t => t.SCHEDULE1)
                .WithMany(t => t.VIDEO_STREAM)
                .HasForeignKey(d => d.Schedule);
            this.HasOptional(t => t.SCHEDULE2)
                .WithMany(t => t.VIDEO_STREAM1)
                .HasForeignKey(d => d.Schedule);
            this.HasOptional(t => t.SHOW_DATE)
                .WithMany(t => t.VIDEO_STREAM)
                .HasForeignKey(d => d.ShowDay);
            this.HasOptional(t => t.SHOW_DATE1)
                .WithMany(t => t.VIDEO_STREAM1)
                .HasForeignKey(d => d.ShowDay);

        }
    }
}
