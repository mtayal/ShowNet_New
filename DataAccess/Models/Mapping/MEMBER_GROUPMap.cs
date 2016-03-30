using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class MEMBER_GROUPMap : EntityTypeConfiguration<MEMBER_GROUP>
    {
        public MEMBER_GROUPMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("MEMBER_GROUP");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Member).HasColumnName("Member");
            this.Property(t => t.AssociatedMember).HasColumnName("AssociatedMember");

            // Relationships
            this.HasOptional(t => t.MEMBER_DETAILS)
                .WithMany(t => t.MEMBER_GROUP)
                .HasForeignKey(d => d.Member);
            this.HasOptional(t => t.MEMBER_DETAILS1)
                .WithMany(t => t.MEMBER_GROUP1)
                .HasForeignKey(d => d.AssociatedMember);
            this.HasOptional(t => t.MEMBER_DETAILS2)
                .WithMany(t => t.MEMBER_GROUP2)
                .HasForeignKey(d => d.Member);
            this.HasOptional(t => t.MEMBER_DETAILS3)
                .WithMany(t => t.MEMBER_GROUP3)
                .HasForeignKey(d => d.AssociatedMember);

        }
    }
}
