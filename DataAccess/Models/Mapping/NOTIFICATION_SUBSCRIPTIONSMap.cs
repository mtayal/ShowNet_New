using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NOTIFICATION_SUBSCRIPTIONSMap : EntityTypeConfiguration<NOTIFICATION_SUBSCRIPTIONS>
    {
        public NOTIFICATION_SUBSCRIPTIONSMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JobID, t.MemberID });

            // Properties
            this.Property(t => t.JobID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MemberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("NOTIFICATION_SUBSCRIPTIONS");
            this.Property(t => t.JobID).HasColumnName("JobID");
            this.Property(t => t.MemberID).HasColumnName("MemberID");

            // Relationships
            this.HasRequired(t => t.JOB)
                .WithMany(t => t.NOTIFICATION_SUBSCRIPTIONS)
                .HasForeignKey(d => d.JobID);
            this.HasRequired(t => t.MEMBER_DETAILS)
                .WithMany(t => t.NOTIFICATION_SUBSCRIPTIONS)
                .HasForeignKey(d => d.MemberID);
            this.HasRequired(t => t.MEMBER_DETAILS1)
                .WithMany(t => t.NOTIFICATION_SUBSCRIPTIONS1)
                .HasForeignKey(d => d.MemberID);
            this.HasRequired(t => t.NOTIFICATION_JOBS)
                .WithMany(t => t.NOTIFICATION_SUBSCRIPTIONS)
                .HasForeignKey(d => d.JobID);
            this.HasRequired(t => t.NOTIFICATION_JOBS1)
                .WithMany(t => t.NOTIFICATION_SUBSCRIPTIONS1)
                .HasForeignKey(d => d.JobID);

        }
    }
}
