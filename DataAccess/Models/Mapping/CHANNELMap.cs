using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class CHANNELMap : EntityTypeConfiguration<CHANNEL>
    {
        public CHANNELMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(255);

            this.Property(t => t.Title)
                .HasMaxLength(255);

            this.Property(t => t.ShortTitle)
                .HasMaxLength(255);

            this.Property(t => t.Link)
                .HasMaxLength(255);

            this.Property(t => t.ThumbNail)
                .HasMaxLength(255);

            this.Property(t => t.Guid)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("CHANNEL");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.ShortTitle).HasColumnName("ShortTitle");
            this.Property(t => t.Link).HasColumnName("Link");
            this.Property(t => t.ThumbNail).HasColumnName("ThumbNail");
            this.Property(t => t.Guid).HasColumnName("Guid");
            this.Property(t => t.IsDisabled).HasColumnName("IsDisabled");
            this.Property(t => t.IsLive).HasColumnName("IsLive");
            this.Property(t => t.MaxViewers).HasColumnName("MaxViewers");
            this.Property(t => t.LastRefresh).HasColumnName("LastRefresh");
            this.Property(t => t.VodClips).HasColumnName("VodClips");
            this.Property(t => t.RecordedClips).HasColumnName("RecordedClips");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.OrderIndex).HasColumnName("OrderIndex");
            this.Property(t => t.IsGlobalFree).HasColumnName("IsGlobalFree");
        }
    }
}
