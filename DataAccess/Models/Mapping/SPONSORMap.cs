using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SPONSORMap : EntityTypeConfiguration<SPONSOR>
    {
        public SPONSORMap()
        {
            // Primary Key
            this.HasKey(t => t.SponsorID);

            // Properties
            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.URL)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ImageURL)
                .HasMaxLength(250);

            this.Property(t => t.VideoSplashURL)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("SPONSORS");
            this.Property(t => t.SponsorID).HasColumnName("SponsorID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");
            this.Property(t => t.URL).HasColumnName("URL");
            this.Property(t => t.ImageURL).HasColumnName("ImageURL");
            this.Property(t => t.IsMainSponsor).HasColumnName("IsMainSponsor");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.VideoSplashURL).HasColumnName("VideoSplashURL");
            this.Property(t => t.UseVideoSplash).HasColumnName("UseVideoSplash");
            this.Property(t => t.MaximumPlay).HasColumnName("MaximumPlay");
        }
    }
}
