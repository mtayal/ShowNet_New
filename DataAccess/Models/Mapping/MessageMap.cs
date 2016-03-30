using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            // Primary Key
            this.HasKey(t => t.MessageID);

            // Properties
            this.Property(t => t.HeadLine)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Message");
            this.Property(t => t.MessageID).HasColumnName("MessageID");
            this.Property(t => t.HeadLine).HasColumnName("HeadLine");
            this.Property(t => t.Body).HasColumnName("Body");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");
            this.Property(t => t.PostedTime).HasColumnName("PostedTime");
            this.Property(t => t.SentStatus).HasColumnName("SentStatus");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.Visible).HasColumnName("Visible");
        }
    }
}
