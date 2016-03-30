using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class HORSE_SHOWMap : EntityTypeConfiguration<HORSE_SHOW>
    {
        public HORSE_SHOWMap()
        {
            // Primary Key
            this.HasKey(t => t.HorseShowID);

            // Properties
            this.Property(t => t.HorseShowName)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.Location)
                .HasMaxLength(60);

            this.Property(t => t.Comment)
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .HasMaxLength(20);

            this.Property(t => t.ShowImage)
                .HasMaxLength(255);

            this.Property(t => t.ShowWebsite)
                .HasMaxLength(255);

            this.Property(t => t.SponsorIDList)
                .HasMaxLength(255);

            this.Property(t => t.AvailableProducts)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("HORSE_SHOW");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.HorseShowName).HasColumnName("HorseShowName");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.LongDescription).HasColumnName("LongDescription");
            this.Property(t => t.ShowImage).HasColumnName("ShowImage");
            this.Property(t => t.ShowWebsite).HasColumnName("ShowWebsite");
            this.Property(t => t.SponsorIDList).HasColumnName("SponsorIDList");
            this.Property(t => t.IsWWWVisible).HasColumnName("IsWWWVisible");
            this.Property(t => t.IsFreeMobileWatch).HasColumnName("IsFreeMobileWatch");
            this.Property(t => t.HasScheduleDownload).HasColumnName("HasScheduleDownload");
            this.Property(t => t.HasPrizeListDownload).HasColumnName("HasPrizeListDownload");
            this.Property(t => t.HasEntryBlankDownload).HasColumnName("HasEntryBlankDownload");
            this.Property(t => t.ShowMode).HasColumnName("ShowMode");
            this.Property(t => t.IsFreeShow).HasColumnName("IsFreeShow");
            this.Property(t => t.HasVideo).HasColumnName("HasVideo");
            this.Property(t => t.RequiresCircuit).HasColumnName("RequiresCircuit");
            this.Property(t => t.HasStreaming).HasColumnName("HasStreaming");
            this.Property(t => t.RequiresRegistration).HasColumnName("RequiresRegistration");
            this.Property(t => t.AvailableProducts).HasColumnName("AvailableProducts");
        }
    }
}
