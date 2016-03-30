using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class EMAIL_START_TIMEMap : EntityTypeConfiguration<EMAIL_START_TIME>
    {
        public EMAIL_START_TIMEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.HorseShowName)
                .HasMaxLength(255);

            this.Property(t => t.ClassName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("EMAIL_START_TIME");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MailTo).HasColumnName("MailTo");
            this.Property(t => t.MailFrom).HasColumnName("MailFrom");
            this.Property(t => t.MailSubject).HasColumnName("MailSubject");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.HorseShowName).HasColumnName("HorseShowName");
            this.Property(t => t.ClassName).HasColumnName("ClassName");
            this.Property(t => t.OrigStartTime).HasColumnName("OrigStartTime");
            this.Property(t => t.NewStartTime).HasColumnName("NewStartTime");
            this.Property(t => t.MessageBody).HasColumnName("MessageBody");
            this.Property(t => t.IsProcessed).HasColumnName("IsProcessed");
            this.Property(t => t.ServiceID).HasColumnName("ServiceID");
            this.Property(t => t.ClassID).HasColumnName("ClassID");
            this.Property(t => t.ScheduleID).HasColumnName("ScheduleID");
            this.Property(t => t.ShowDayID).HasColumnName("ShowDayID");
            this.Property(t => t.ServiceTypeID).HasColumnName("ServiceTypeID");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
        }
    }
}
