using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class AUDITMap : EntityTypeConfiguration<AUDIT>
    {
        public AUDITMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.IPAddress)
                .HasMaxLength(255);

            this.Property(t => t.SiteLocation)
                .HasMaxLength(2000);

            this.Property(t => t.SessionID)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("AUDIT");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.IPAddress).HasColumnName("IPAddress");
            this.Property(t => t.SiteLocation).HasColumnName("SiteLocation");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.UserAgent).HasColumnName("UserAgent");
            this.Property(t => t.SessionID).HasColumnName("SessionID");

            // Relationships
            this.HasOptional(t => t.MEMBER_DETAILS)
                .WithMany(t => t.AUDITs)
                .HasForeignKey(d => d.MemberID);
            this.HasOptional(t => t.MEMBER_DETAILS1)
                .WithMany(t => t.AUDITs1)
                .HasForeignKey(d => d.MemberID);

        }
    }
}
