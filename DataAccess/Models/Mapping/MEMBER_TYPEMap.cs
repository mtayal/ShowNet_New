using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class MEMBER_TYPEMap : EntityTypeConfiguration<MEMBER_TYPE>
    {
        public MEMBER_TYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.TypeID);

            // Properties
            this.Property(t => t.TypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MemberType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("MEMBER_TYPE");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.MemberType).HasColumnName("MemberType");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.WriteData).HasColumnName("WriteData");
            this.Property(t => t.IncludedValueInCents).HasColumnName("IncludedValueInCents");
            this.Property(t => t.ContractLengthInDays).HasColumnName("ContractLengthInDays");
            this.Property(t => t.IsSuperUser).HasColumnName("IsSuperUser");
        }
    }
}
