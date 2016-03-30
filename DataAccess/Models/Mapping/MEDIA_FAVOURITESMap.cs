using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class MEDIA_FAVOURITESMap : EntityTypeConfiguration<MEDIA_FAVOURITES>
    {
        public MEDIA_FAVOURITESMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("MEDIA_FAVOURITES");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
        }
    }
}
