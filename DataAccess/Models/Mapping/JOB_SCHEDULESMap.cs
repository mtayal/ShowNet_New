using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class JOB_SCHEDULESMap : EntityTypeConfiguration<JOB_SCHEDULES>
    {
        public JOB_SCHEDULESMap()
        {
            // Primary Key
            this.HasKey(t => t.JobScheduleID);

            // Properties
            // Table & Column Mappings
            this.ToTable("JOB_SCHEDULES");
            this.Property(t => t.JobScheduleID).HasColumnName("JobScheduleID");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.JobID).HasColumnName("JobID");
            this.Property(t => t.StartDateUtc).HasColumnName("StartDateUtc");
            this.Property(t => t.Frequency).HasColumnName("Frequency");
            this.Property(t => t.FrequencyInterval).HasColumnName("FrequencyInterval");
            this.Property(t => t.Enabled).HasColumnName("Enabled");

            // Relationships
            this.HasRequired(t => t.JOB)
                .WithMany(t => t.JOB_SCHEDULES)
                .HasForeignKey(d => d.JobID);
            this.HasRequired(t => t.JOB1)
                .WithMany(t => t.JOB_SCHEDULES1)
                .HasForeignKey(d => d.JobID);
            this.HasRequired(t => t.JOB2)
                .WithMany(t => t.JOB_SCHEDULES2)
                .HasForeignKey(d => d.JobID);

        }
    }
}
