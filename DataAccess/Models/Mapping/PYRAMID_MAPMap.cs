using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PYRAMID_MAPMap : EntityTypeConfiguration<PYRAMID_MAP>
    {
        public PYRAMID_MAPMap()
        {
            // Primary Key
            this.HasKey(t => t.PyramidMapID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PYRAMID_MAP");
            this.Property(t => t.PyramidMapID).HasColumnName("PyramidMapID");
            this.Property(t => t.PyramidCompetitionID).HasColumnName("PyramidCompetitionID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
        }
    }
}
