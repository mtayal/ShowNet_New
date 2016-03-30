using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class MEMBER_SERVICESMap : EntityTypeConfiguration<MEMBER_SERVICES>
    {
        public MEMBER_SERVICESMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ServiceID, t.IsProcessed });

            // Properties
            this.Property(t => t.ServiceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("MEMBER_SERVICES");
            this.Property(t => t.ServiceID).HasColumnName("ServiceID");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.EmailService).HasColumnName("EmailService");
            this.Property(t => t.BackNoTracking).HasColumnName("BackNoTracking");
            this.Property(t => t.IsProcessed).HasColumnName("IsProcessed");
            this.Property(t => t.ServiceTypeID).HasColumnName("ServiceTypeID");
            this.Property(t => t.LastSent).HasColumnName("LastSent");
        }
    }
}
