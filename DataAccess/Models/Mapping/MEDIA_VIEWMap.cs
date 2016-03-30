using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class MEDIA_VIEWMap : EntityTypeConfiguration<MEDIA_VIEW>
    {
        public MEDIA_VIEWMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("MEDIA_VIEW");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Views).HasColumnName("Views");
            this.Property(t => t.LastViewed).HasColumnName("LastViewed");
            this.Property(t => t.MemberDetails).HasColumnName("MemberDetails");
            this.Property(t => t.Media).HasColumnName("Media");

            // Relationships
            this.HasOptional(t => t.Medium)
                .WithMany(t => t.MEDIA_VIEW)
                .HasForeignKey(d => d.Media);
            this.HasOptional(t => t.MEMBER_DETAILS)
                .WithMany(t => t.MEDIA_VIEW)
                .HasForeignKey(d => d.MemberDetails);

        }
    }
}
