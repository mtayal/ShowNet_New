using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class JOBMap : EntityTypeConfiguration<JOB>
    {
        public JOBMap()
        {
            // Primary Key
            this.HasKey(t => t.JobID);

            // Properties
            this.Property(t => t.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("JOBS");
            this.Property(t => t.JobID).HasColumnName("JobID");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.CreatedDateUtc).HasColumnName("CreatedDateUtc");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedDateUtc).HasColumnName("ModifiedDateUtc");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ReadOnly).HasColumnName("ReadOnly");
            this.Property(t => t.Enabled).HasColumnName("Enabled");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.TriggerType).HasColumnName("TriggerType");
            this.Property(t => t.JobTypeID).HasColumnName("JobTypeID");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasRequired(t => t.JOB_TYPES)
                .WithMany(t => t.JOBS)
                .HasForeignKey(d => d.JobTypeID);
            this.HasRequired(t => t.JOB_TYPES1)
                .WithMany(t => t.JOBS1)
                .HasForeignKey(d => d.JobTypeID);
            this.HasRequired(t => t.JOB_TYPES2)
                .WithMany(t => t.JOBS2)
                .HasForeignKey(d => d.JobTypeID);

        }
    }
}
