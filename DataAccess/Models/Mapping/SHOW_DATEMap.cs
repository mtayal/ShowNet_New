using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SHOW_DATEMap : EntityTypeConfiguration<SHOW_DATE>
    {
        public SHOW_DATEMap()
        {
            // Primary Key
            this.HasKey(t => t.ShowDayID);

            // Properties
            this.Property(t => t.Comment)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SHOW_DATE");
            this.Property(t => t.ShowDayID).HasColumnName("ShowDayID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.ShowDate).HasColumnName("ShowDate");
            this.Property(t => t.RingID).HasColumnName("RingID");
            this.Property(t => t.CurrentSeqNo).HasColumnName("CurrentSeqNo");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");
            this.Property(t => t.CurSchedID1).HasColumnName("CurSchedID1");
            this.Property(t => t.CurSchedID2).HasColumnName("CurSchedID2");
            this.Property(t => t.Comment).HasColumnName("Comment");

            // Relationships
            this.HasRequired(t => t.HORSE_SHOW)
                .WithMany(t => t.SHOW_DATE)
                .HasForeignKey(d => d.HorseShowID);
            this.HasRequired(t => t.HORSE_SHOW1)
                .WithMany(t => t.SHOW_DATE1)
                .HasForeignKey(d => d.HorseShowID);
            this.HasRequired(t => t.HORSE_SHOW2)
                .WithMany(t => t.SHOW_DATE2)
                .HasForeignKey(d => d.HorseShowID);
            this.HasRequired(t => t.RING_NAME)
                .WithMany(t => t.SHOW_DATE)
                .HasForeignKey(d => d.RingID);
            this.HasRequired(t => t.RING_NAME1)
                .WithMany(t => t.SHOW_DATE1)
                .HasForeignKey(d => d.RingID);
            this.HasRequired(t => t.RING_NAME2)
                .WithMany(t => t.SHOW_DATE2)
                .HasForeignKey(d => d.RingID);

        }
    }
}
