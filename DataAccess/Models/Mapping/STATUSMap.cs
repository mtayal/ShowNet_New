using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class STATUSMap : EntityTypeConfiguration<STATUS>
    {
        public STATUSMap()
        {
            // Primary Key
            this.HasKey(t => t.StatusID);

            // Properties
            this.Property(t => t.StatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StatusName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("STATUS");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
            this.Property(t => t.StatusName).HasColumnName("StatusName");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");
        }
    }
}
