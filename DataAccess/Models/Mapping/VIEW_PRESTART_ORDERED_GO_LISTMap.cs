using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIEW_PRESTART_ORDERED_GO_LISTMap : EntityTypeConfiguration<VIEW_PRESTART_ORDERED_GO_LIST>
    {
        public VIEW_PRESTART_ORDERED_GO_LISTMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ListID, t.ScheduleID, t.ClassID, t.ShowDayID, t.Ordered, t.HorseShowID, t.HorseShowName, t.HorseName, t.RingID, t.RingName, t.BackID, t.OrderIndex, t.ShowDate, t.Owner1, t.ModeID, t.ShowMode });

            // Properties
            this.Property(t => t.ListID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ScheduleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ClassID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ClassName)
                .HasMaxLength(60);

            this.Property(t => t.ShowDayID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HorseShowID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RiderName)
                .HasMaxLength(50);

            this.Property(t => t.HorseShowName)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.HorseName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Rider)
                .HasMaxLength(50);

            this.Property(t => t.RingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RingName)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.BackID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderIndex)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Owner1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ModeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Draw)
                .HasMaxLength(10);

            this.Property(t => t.ShowMode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VIEW_PRESTART_ORDERED_GO_LIST");
            this.Property(t => t.ListID).HasColumnName("ListID");
            this.Property(t => t.ScheduleID).HasColumnName("ScheduleID");
            this.Property(t => t.ClassID).HasColumnName("ClassID");
            this.Property(t => t.ClassName).HasColumnName("ClassName");
            this.Property(t => t.ShowDayID).HasColumnName("ShowDayID");
            this.Property(t => t.Ordered).HasColumnName("Ordered");
            this.Property(t => t.ETA).HasColumnName("ETA");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.RiderName).HasColumnName("RiderName");
            this.Property(t => t.HorseShowName).HasColumnName("HorseShowName");
            this.Property(t => t.HorseName).HasColumnName("HorseName");
            this.Property(t => t.Rider).HasColumnName("Rider");
            this.Property(t => t.RingID).HasColumnName("RingID");
            this.Property(t => t.RingName).HasColumnName("RingName");
            this.Property(t => t.BackID).HasColumnName("BackID");
            this.Property(t => t.OrderIndex).HasColumnName("OrderIndex");
            this.Property(t => t.ShowDate).HasColumnName("ShowDate");
            this.Property(t => t.Owner1).HasColumnName("Owner1");
            this.Property(t => t.ModeID).HasColumnName("ModeID");
            this.Property(t => t.Draw).HasColumnName("Draw");
            this.Property(t => t.ShowMode).HasColumnName("ShowMode");
        }
    }
}
