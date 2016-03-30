using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class DASHBOARD_NOTIFICATIONMap : EntityTypeConfiguration<DASHBOARD_NOTIFICATION>
    {
        public DASHBOARD_NOTIFICATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Subject)
                .HasMaxLength(255);

            this.Property(t => t.Body)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("DASHBOARD_NOTIFICATION");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Subject).HasColumnName("Subject");
            this.Property(t => t.Body).HasColumnName("Body");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.JobID).HasColumnName("JobID");
        }
    }
}
