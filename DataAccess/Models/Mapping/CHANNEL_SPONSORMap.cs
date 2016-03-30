using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class CHANNEL_SPONSORMap : EntityTypeConfiguration<CHANNEL_SPONSOR>
    {
        public CHANNEL_SPONSORMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CHANNEL_SPONSOR");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SponsorID).HasColumnName("SponsorID");
            this.Property(t => t.ChannelScheduleId).HasColumnName("ChannelScheduleId");
            this.Property(t => t.IsDisabled).HasColumnName("IsDisabled");
        }
    }
}
