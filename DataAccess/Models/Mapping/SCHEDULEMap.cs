using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SCHEDULEMap : EntityTypeConfiguration<SCHEDULE>
    {
        public SCHEDULEMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleID);

            // Properties
            this.Property(t => t.ClassID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ClassName)
                .HasMaxLength(60);

            this.Property(t => t.RingStatus)
                .HasMaxLength(10);

            this.Property(t => t.Comment)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SCHEDULE");
            this.Property(t => t.ScheduleID).HasColumnName("ScheduleID");
            this.Property(t => t.ShowDayID).HasColumnName("ShowDayID");
            this.Property(t => t.ClassID).HasColumnName("ClassID");
            this.Property(t => t.ClassName).HasColumnName("ClassName");
            this.Property(t => t.Ordered).HasColumnName("Ordered");
            this.Property(t => t.SeqNo).HasColumnName("SeqNo");
            this.Property(t => t.ModeID).HasColumnName("ModeID");
            this.Property(t => t.ETA).HasColumnName("ETA");
            this.Property(t => t.RingStatus).HasColumnName("RingStatus");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.Approved).HasColumnName("Approved");
            this.Property(t => t.TimeAllowed1).HasColumnName("TimeAllowed1");
            this.Property(t => t.R2Return).HasColumnName("R2Return");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.TimeAllowed2).HasColumnName("TimeAllowed2");
            this.Property(t => t.RootScheduleID).HasColumnName("RootScheduleID");
            this.Property(t => t.ParentScheduleID).HasColumnName("ParentScheduleID");

            // Relationships
            this.HasRequired(t => t.MODE)
                .WithMany(t => t.SCHEDULEs)
                .HasForeignKey(d => d.ModeID);
            this.HasRequired(t => t.MODE1)
                .WithMany(t => t.SCHEDULEs1)
                .HasForeignKey(d => d.ModeID);
            this.HasRequired(t => t.SHOW_DATE)
                .WithMany(t => t.SCHEDULEs)
                .HasForeignKey(d => d.ShowDayID);
            this.HasRequired(t => t.SHOW_DATE1)
                .WithMany(t => t.SCHEDULEs1)
                .HasForeignKey(d => d.ShowDayID);
            this.HasRequired(t => t.SHOW_DATE2)
                .WithMany(t => t.SCHEDULEs2)
                .HasForeignKey(d => d.ShowDayID);

        }
    }
}
