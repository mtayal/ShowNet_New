using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class WEB_ERRORMap : EntityTypeConfiguration<WEB_ERROR>
    {
        public WEB_ERRORMap()
        {
            // Primary Key
            this.HasKey(t => t.ErrorID);

            // Properties
            // Table & Column Mappings
            this.ToTable("WEB_ERROR");
            this.Property(t => t.ErrorID).HasColumnName("ErrorID");
            this.Property(t => t.ErrorMessage).HasColumnName("ErrorMessage");
            this.Property(t => t.ErrorTrace).HasColumnName("ErrorTrace");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
        }
    }
}
