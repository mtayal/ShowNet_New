using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class JOB_TYPESMap : EntityTypeConfiguration<JOB_TYPES>
    {
        public JOB_TYPESMap()
        {
            // Primary Key
            this.HasKey(t => t.JobTypeID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FriendlyName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("JOB_TYPES");
            this.Property(t => t.JobTypeID).HasColumnName("JobTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.FriendlyName).HasColumnName("FriendlyName");
        }
    }
}
