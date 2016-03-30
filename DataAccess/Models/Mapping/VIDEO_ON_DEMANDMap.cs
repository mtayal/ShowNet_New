using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIDEO_ON_DEMANDMap : EntityTypeConfiguration<VIDEO_ON_DEMAND>
    {
        public VIDEO_ON_DEMANDMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(255);

            this.Property(t => t.Title)
                .HasMaxLength(255);

            this.Property(t => t.Link)
                .HasMaxLength(255);

            this.Property(t => t.ThumbNail)
                .HasMaxLength(255);

            this.Property(t => t.Guid)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("VIDEO_ON_DEMAND");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Link).HasColumnName("Link");
            this.Property(t => t.ThumbNail).HasColumnName("ThumbNail");
            this.Property(t => t.Guid).HasColumnName("Guid");
            this.Property(t => t.IsDisabled).HasColumnName("IsDisabled");
            this.Property(t => t.Source).HasColumnName("Source");
        }
    }
}
