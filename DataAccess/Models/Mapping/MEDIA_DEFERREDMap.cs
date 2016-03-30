using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class MEDIA_DEFERREDMap : EntityTypeConfiguration<MEDIA_DEFERRED>
    {
        public MEDIA_DEFERREDMap()
        {
            // Primary Key
            this.HasKey(t => t.DeferredMediaID);

            // Properties
            // Table & Column Mappings
            this.ToTable("MEDIA_DEFERRED");
            this.Property(t => t.DeferredMediaID).HasColumnName("DeferredMediaID");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
            this.Property(t => t.ListID).HasColumnName("ListID");
            this.Property(t => t.IsProcessed).HasColumnName("IsProcessed");
            this.Property(t => t.MediaDeferredID).HasColumnName("MediaDeferredID");

            // Relationships
            this.HasRequired(t => t.Medium)
                .WithMany(t => t.MEDIA_DEFERRED)
                .HasForeignKey(d => d.MediaID);
            this.HasRequired(t => t.Medium1)
                .WithMany(t => t.MEDIA_DEFERRED1)
                .HasForeignKey(d => d.MediaID);

        }
    }
}
