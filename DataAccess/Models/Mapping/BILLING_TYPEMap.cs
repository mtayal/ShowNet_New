using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class BILLING_TYPEMap : EntityTypeConfiguration<BILLING_TYPE>
    {
        public BILLING_TYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.BILLING_TYPEID);

            // Properties
            this.Property(t => t.BILLING_TYPE1)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BILLING_TYPE");
            this.Property(t => t.BILLING_TYPEID).HasColumnName("BILLING_TYPEID");
            this.Property(t => t.BILLING_TYPE1).HasColumnName("BILLING_TYPE");
        }
    }
}
