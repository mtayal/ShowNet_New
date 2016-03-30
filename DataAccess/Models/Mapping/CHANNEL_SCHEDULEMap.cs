using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class CHANNEL_SCHEDULEMap : EntityTypeConfiguration<CHANNEL_SCHEDULE>
    {
        public CHANNEL_SCHEDULEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CHANNEL_SCHEDULE");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ShowDayId).HasColumnName("ShowDayId");
            this.Property(t => t.IsDisabled).HasColumnName("IsDisabled");
            this.Property(t => t.IsFree).HasColumnName("IsFree");
            this.Property(t => t.Channel).HasColumnName("Channel");

            // Relationships
            this.HasOptional(t => t.SHOW_DATE)
                .WithMany(t => t.CHANNEL_SCHEDULE)
                .HasForeignKey(d => d.ShowDayId);

        }
    }
}
