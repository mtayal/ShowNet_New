using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class MEMBER_TRACKED_ENTRANTSMap : EntityTypeConfiguration<MEMBER_TRACKED_ENTRANTS>
    {
        public MEMBER_TRACKED_ENTRANTSMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MemberID, t.HorseShowID, t.BackID });

            // Properties
            this.Property(t => t.MemberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HorseShowID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BackID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MEMBER_TRACKED_ENTRANTS");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.BackID).HasColumnName("BackID");

            // Relationships
            this.HasRequired(t => t.MEMBER_DETAILS)
                .WithMany(t => t.MEMBER_TRACKED_ENTRANTS)
                .HasForeignKey(d => d.MemberID);
            this.HasRequired(t => t.MEMBER_DETAILS1)
                .WithMany(t => t.MEMBER_TRACKED_ENTRANTS1)
                .HasForeignKey(d => d.MemberID);

        }
    }
}
