using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PAYMENT_TYPEMap : EntityTypeConfiguration<PAYMENT_TYPE>
    {
        public PAYMENT_TYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.PAYMENT_TYPE_ID);

            // Properties
            this.Property(t => t.PAYMENT_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PAYMENT_TYPE1)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PAYMENT_TYPE");
            this.Property(t => t.PAYMENT_TYPE_ID).HasColumnName("PAYMENT_TYPE_ID");
            this.Property(t => t.PAYMENT_TYPE1).HasColumnName("PAYMENT_TYPE");
            this.Property(t => t.PAYMENT_TYPEID).HasColumnName("PAYMENT_TYPEID");
        }
    }
}
