using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PYRAMID_LOGMap : EntityTypeConfiguration<PYRAMID_LOG>
    {
        public PYRAMID_LOGMap()
        {
            // Primary Key
            this.HasKey(t => t.PyramidLogID);

            // Properties
            this.Property(t => t.ClassID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PYRAMID_LOG");
            this.Property(t => t.PyramidLogID).HasColumnName("PyramidLogID");
            this.Property(t => t.Raw).HasColumnName("Raw");
            this.Property(t => t.DTO).HasColumnName("DTO");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.XmlDecodeDTO).HasColumnName("XmlDecodeDTO");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.ClassID).HasColumnName("ClassID");
            this.Property(t => t.IsResend).HasColumnName("IsResend");
            this.Property(t => t.Message).HasColumnName("Message");
        }
    }
}
