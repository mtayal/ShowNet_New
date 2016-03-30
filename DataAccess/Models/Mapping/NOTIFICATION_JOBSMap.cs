using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NOTIFICATION_JOBSMap : EntityTypeConfiguration<NOTIFICATION_JOBS>
    {
        public NOTIFICATION_JOBSMap()
        {
            // Primary Key
            this.HasKey(t => t.JobID);

            // Properties
            this.Property(t => t.JobID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("NOTIFICATION_JOBS");
            this.Property(t => t.JobID).HasColumnName("JobID");
            this.Property(t => t.DeliveryMethods).HasColumnName("DeliveryMethods");
            this.Property(t => t.Category).HasColumnName("Category");

            // Relationships
            this.HasRequired(t => t.JOB)
                .WithOptional(t => t.NOTIFICATION_JOBS);
            this.HasRequired(t => t.JOB1)
                .WithOptional(t => t.NOTIFICATION_JOBS1);
            this.HasRequired(t => t.JOB2)
                .WithOptional(t => t.NOTIFICATION_JOBS2);

        }
    }
}
