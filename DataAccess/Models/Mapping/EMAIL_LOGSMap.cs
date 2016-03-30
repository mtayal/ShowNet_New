using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class EMAIL_LOGSMap : EntityTypeConfiguration<EMAIL_LOGS>
    {
        public EMAIL_LOGSMap()
        {
            // Primary Key
            this.HasKey(t => t.LogID);

            // Properties
            this.Property(t => t.TimeSent)
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("EMAIL_LOGS");
            this.Property(t => t.LogID).HasColumnName("LogID");
            this.Property(t => t.MailTo).HasColumnName("MailTo");
            this.Property(t => t.MailCC).HasColumnName("MailCC");
            this.Property(t => t.MailBCC).HasColumnName("MailBCC");
            this.Property(t => t.Mailbody).HasColumnName("Mailbody");
            this.Property(t => t.MailSubject).HasColumnName("MailSubject");
            this.Property(t => t.TimeSent).HasColumnName("TimeSent");
            this.Property(t => t.TimeSent2).HasColumnName("TimeSent2");
        }
    }
}
