using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class MEMBER_FAVORITESMap : EntityTypeConfiguration<MEMBER_FAVORITES>
    {
        public MEMBER_FAVORITESMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.MemberID, t.IsGUIVisible });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.MemberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MEMBER_FAVORITES");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.BackID).HasColumnName("BackID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.IsGUIVisible).HasColumnName("IsGUIVisible");

            // Relationships
            this.HasOptional(t => t.HORSE_SHOW)
                .WithMany(t => t.MEMBER_FAVORITES)
                .HasForeignKey(d => d.HorseShowID);
            this.HasOptional(t => t.HORSE_SHOW1)
                .WithMany(t => t.MEMBER_FAVORITES1)
                .HasForeignKey(d => d.HorseShowID);
            this.HasRequired(t => t.MEMBER_DETAILS)
                .WithMany(t => t.MEMBER_FAVORITES)
                .HasForeignKey(d => d.MemberID);
            this.HasRequired(t => t.MEMBER_DETAILS1)
                .WithMany(t => t.MEMBER_FAVORITES1)
                .HasForeignKey(d => d.MemberID);

        }
    }
}
