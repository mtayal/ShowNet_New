using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class WS_LOGSMap : EntityTypeConfiguration<WS_LOGS>
    {
        public WS_LOGSMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Username)
                .HasMaxLength(50);

            this.Property(t => t.IP)
                .HasMaxLength(100);

            this.Property(t => t.Service)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("WS_LOGS");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.Service).HasColumnName("Service");
            this.Property(t => t.Params).HasColumnName("Params");
        }
    }
}
