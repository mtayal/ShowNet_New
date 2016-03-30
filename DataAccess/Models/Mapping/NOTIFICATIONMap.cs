using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NOTIFICATIONMap : EntityTypeConfiguration<NOTIFICATION>
    {
        public NOTIFICATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.NotificationID);

            // Properties
            // Table & Column Mappings
            this.ToTable("NOTIFICATIONS");
            this.Property(t => t.NotificationID).HasColumnName("NotificationID");
        }
    }
}
