using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIDEO_PUBLISHMap : EntityTypeConfiguration<VIDEO_PUBLISH>
    {
        public VIDEO_PUBLISHMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PublishOutlet)
                .HasMaxLength(255);

            this.Property(t => t.PublishUri)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("VIDEO_PUBLISH");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PublishOutlet).HasColumnName("PublishOutlet");
            this.Property(t => t.PublishUri).HasColumnName("PublishUri");
            this.Property(t => t.PublishTime).HasColumnName("PublishTime");
            this.Property(t => t.IsPublished).HasColumnName("IsPublished");
            this.Property(t => t.IsError).HasColumnName("IsError");
            this.Property(t => t.ErrorMessage).HasColumnName("ErrorMessage");
            this.Property(t => t.Media).HasColumnName("Media");
            this.Property(t => t.Member).HasColumnName("Member");

            // Relationships
            this.HasOptional(t => t.Medium)
                .WithMany(t => t.VIDEO_PUBLISH)
                .HasForeignKey(d => d.Media);
            this.HasOptional(t => t.Medium1)
                .WithMany(t => t.VIDEO_PUBLISH2)
                .HasForeignKey(d => d.Media);
            this.HasOptional(t => t.MEMBER_DETAILS)
                .WithMany(t => t.VIDEO_PUBLISH)
                .HasForeignKey(d => d.Member);
            this.HasOptional(t => t.MEMBER_DETAILS2)
                .WithMany(t => t.VIDEO_PUBLISH2)
                .HasForeignKey(d => d.Member);

        }
    }
}
