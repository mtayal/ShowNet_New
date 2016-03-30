using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NCAA_SHOWMap : EntityTypeConfiguration<NCAA_SHOW>
    {
        public NCAA_SHOWMap()
        {
            // Primary Key
            this.HasKey(t => t.HorseShowID);

            // Properties
            this.Property(t => t.HorseShowName)
                .HasMaxLength(255);

            this.Property(t => t.Location)
                .HasMaxLength(255);

            this.Property(t => t.Comment)
                .HasMaxLength(255);

            this.Property(t => t.Password)
                .HasMaxLength(255);

            this.Property(t => t.LongDescription)
                .HasMaxLength(255);

            this.Property(t => t.ShowImage)
                .HasMaxLength(255);

            this.Property(t => t.ShowWebsite)
                .HasMaxLength(255);

            this.Property(t => t.SponsorIDList)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("NCAA_SHOW");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.HorseShowName).HasColumnName("HorseShowName");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.LongDescription).HasColumnName("LongDescription");
            this.Property(t => t.ShowImage).HasColumnName("ShowImage");
            this.Property(t => t.ShowWebsite).HasColumnName("ShowWebsite");
            this.Property(t => t.SponsorIDList).HasColumnName("SponsorIDList");
        }
    }
}
