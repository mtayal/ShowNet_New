using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SERVICE_TYPESMap : EntityTypeConfiguration<SERVICE_TYPES>
    {
        public SERVICE_TYPESMap()
        {
            // Primary Key
            this.HasKey(t => t.ServiceTypeID);

            // Properties
            this.Property(t => t.ServiceTypeName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SERVICE_TYPES");
            this.Property(t => t.ServiceTypeID).HasColumnName("ServiceTypeID");
            this.Property(t => t.ServiceTypeName).HasColumnName("ServiceTypeName");
            this.Property(t => t.ServiceTypeDescription).HasColumnName("ServiceTypeDescription");
            this.Property(t => t.ServiceTypeActive).HasColumnName("ServiceTypeActive");
            this.Property(t => t.OrderIndex).HasColumnName("OrderIndex");
        }
    }
}
