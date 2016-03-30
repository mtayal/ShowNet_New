using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ORDERED_GO_LISTMap : EntityTypeConfiguration<ORDERED_GO_LIST>
    {
        public ORDERED_GO_LISTMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ScheduleID, t.BackID });

            // Properties
            this.Property(t => t.ListID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ScheduleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ClassID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.BackID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RiderName)
                .HasMaxLength(50);

            this.Property(t => t.MediaID)
                .HasMaxLength(50);

            this.Property(t => t.Timestamp)
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            this.Property(t => t.Draw)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ORDERED_GO_LIST");
            this.Property(t => t.ListID).HasColumnName("ListID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.ScheduleID).HasColumnName("ScheduleID");
            this.Property(t => t.ClassID).HasColumnName("ClassID");
            this.Property(t => t.OrderIndex).HasColumnName("OrderIndex");
            this.Property(t => t.BackID).HasColumnName("BackID");
            this.Property(t => t.RiderName).HasColumnName("RiderName");
            this.Property(t => t.Started).HasColumnName("Started");
            this.Property(t => t.Scratched).HasColumnName("Scratched");
            this.Property(t => t.StandBy).HasColumnName("StandBy");
            this.Property(t => t.JumpFaults1).HasColumnName("JumpFaults1");
            this.Property(t => t.TimeFaults1).HasColumnName("TimeFaults1");
            this.Property(t => t.TotalFaults1).HasColumnName("TotalFaults1");
            this.Property(t => t.Time1).HasColumnName("Time1");
            this.Property(t => t.JumpFaults2).HasColumnName("JumpFaults2");
            this.Property(t => t.TimeFaults2).HasColumnName("TimeFaults2");
            this.Property(t => t.TotalFaults2).HasColumnName("TotalFaults2");
            this.Property(t => t.Time2).HasColumnName("Time2");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.Rank).HasColumnName("Rank");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");
            this.Property(t => t.Added).HasColumnName("Added");
            this.Property(t => t.GoneIndex).HasColumnName("GoneIndex");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.Modified).HasColumnName("Modified");
            this.Property(t => t.FinalOrder).HasColumnName("FinalOrder");
            this.Property(t => t.Time1Pos).HasColumnName("Time1Pos");
            this.Property(t => t.Time2Pos).HasColumnName("Time2Pos");
            this.Property(t => t.Score2).HasColumnName("Score2");
            this.Property(t => t.TotalScore).HasColumnName("TotalScore");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.E).HasColumnName("E");
            this.Property(t => t.H).HasColumnName("H");
            this.Property(t => t.C).HasColumnName("C");
            this.Property(t => t.M).HasColumnName("M");
            this.Property(t => t.B).HasColumnName("B");
            this.Property(t => t.MaxDresage).HasColumnName("MaxDresage");
            this.Property(t => t.Draw).HasColumnName("Draw");

            // Relationships
            this.HasRequired(t => t.HORSE_SHOW)
                .WithMany(t => t.ORDERED_GO_LIST)
                .HasForeignKey(d => d.HorseShowID);
            this.HasRequired(t => t.HORSE_SHOW1)
                .WithMany(t => t.ORDERED_GO_LIST1)
                .HasForeignKey(d => d.HorseShowID);
            this.HasRequired(t => t.HORSE_SHOW2)
                .WithMany(t => t.ORDERED_GO_LIST2)
                .HasForeignKey(d => d.HorseShowID);
            this.HasRequired(t => t.SCHEDULE)
                .WithMany(t => t.ORDERED_GO_LIST)
                .HasForeignKey(d => d.ScheduleID);
            this.HasRequired(t => t.SCHEDULE1)
                .WithMany(t => t.ORDERED_GO_LIST1)
                .HasForeignKey(d => d.ScheduleID);
            this.HasRequired(t => t.SCHEDULE2)
                .WithMany(t => t.ORDERED_GO_LIST2)
                .HasForeignKey(d => d.ScheduleID);

        }
    }
}
