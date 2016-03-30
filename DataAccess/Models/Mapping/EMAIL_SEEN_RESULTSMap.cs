using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class EMAIL_SEEN_RESULTSMap : EntityTypeConfiguration<EMAIL_SEEN_RESULTS>
    {
        public EMAIL_SEEN_RESULTSMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.MailDelivered });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("EMAIL_SEEN_RESULTS");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ServiceID).HasColumnName("ServiceID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.ShowDayID).HasColumnName("ShowDayID");
            this.Property(t => t.ClassID).HasColumnName("ClassID");
            this.Property(t => t.BackNoTracking).HasColumnName("BackNoTracking");
            this.Property(t => t.EnteredTime).HasColumnName("EnteredTime");
            this.Property(t => t.MailDelivered).HasColumnName("MailDelivered");
            this.Property(t => t.RingID).HasColumnName("RingID");
        }
    }
}
