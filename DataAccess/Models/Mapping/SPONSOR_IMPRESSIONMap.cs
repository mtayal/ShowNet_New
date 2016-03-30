using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SPONSOR_IMPRESSIONMap : EntityTypeConfiguration<SPONSOR_IMPRESSION>
    {
        public SPONSOR_IMPRESSIONMap()
        {
            // Primary Key
            this.HasKey(t => t.SponsorImpressionId);

            // Properties
            this.Property(t => t.Meta)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("SPONSOR_IMPRESSION");
            this.Property(t => t.SponsorImpressionId).HasColumnName("SponsorImpressionId");
            this.Property(t => t.SponsorId).HasColumnName("SponsorId");
            this.Property(t => t.HorseShowId).HasColumnName("HorseShowId");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.MemberId).HasColumnName("MemberId");
            this.Property(t => t.ImpressionSource).HasColumnName("ImpressionSource");
            this.Property(t => t.Meta).HasColumnName("Meta");
        }
    }
}
