using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SHOW_MESSAGES_RELATIONSHIPSMap : EntityTypeConfiguration<SHOW_MESSAGES_RELATIONSHIPS>
    {
        public SHOW_MESSAGES_RELATIONSHIPSMap()
        {
            // Primary Key
            this.HasKey(t => t.ShowMessagesID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SHOW_MESSAGES_RELATIONSHIPS");
            this.Property(t => t.ShowMessagesID).HasColumnName("ShowMessagesID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.HORSE_SHOW)
                .WithMany(t => t.SHOW_MESSAGES_RELATIONSHIPS)
                .HasForeignKey(d => d.HorseShowID);
            this.HasRequired(t => t.MEMBER_DETAILS)
                .WithMany(t => t.SHOW_MESSAGES_RELATIONSHIPS)
                .HasForeignKey(d => d.MemberID);

        }
    }
}
