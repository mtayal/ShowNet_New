using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class RING_NAMEMap : EntityTypeConfiguration<RING_NAME>
    {
        public RING_NAMEMap()
        {
            // Primary Key
            this.HasKey(t => t.RingID);

            // Properties
            this.Property(t => t.RingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RingName)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("RING_NAME");
            this.Property(t => t.RingID).HasColumnName("RingID");
            this.Property(t => t.RingName).HasColumnName("RingName");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");
        }
    }
}
