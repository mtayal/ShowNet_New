using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ENTRANTMap : EntityTypeConfiguration<ENTRANT>
    {
        public ENTRANTMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BackID, t.HorseShowID });

            // Properties
            this.Property(t => t.BackID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HorseShowID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HorseName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Trainer)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Owner1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Owner2)
                .HasMaxLength(50);

            this.Property(t => t.Rider)
                .HasMaxLength(50);

            this.Property(t => t.RiderAddr)
                .HasMaxLength(50);

            this.Property(t => t.Owner1Addr)
                .HasMaxLength(50);

            this.Property(t => t.EntrantID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("ENTRANTS");
            this.Property(t => t.BackID).HasColumnName("BackID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
            this.Property(t => t.HorseName).HasColumnName("HorseName");
            this.Property(t => t.Trainer).HasColumnName("Trainer");
            this.Property(t => t.Owner1).HasColumnName("Owner1");
            this.Property(t => t.Owner2).HasColumnName("Owner2");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");
            this.Property(t => t.Rider).HasColumnName("Rider");
            this.Property(t => t.RiderAddr).HasColumnName("RiderAddr");
            this.Property(t => t.Owner1Addr).HasColumnName("Owner1Addr");
            this.Property(t => t.EntrantID).HasColumnName("EntrantID");

            // Relationships
            this.HasRequired(t => t.STATUS)
                .WithMany(t => t.ENTRANTS)
                .HasForeignKey(d => d.StatusID);
            this.HasRequired(t => t.HORSE_SHOW)
                .WithMany(t => t.ENTRANTS)
                .HasForeignKey(d => d.HorseShowID);
            this.HasRequired(t => t.HORSE_SHOW1)
                .WithMany(t => t.ENTRANTS1)
                .HasForeignKey(d => d.HorseShowID);

        }
    }
}
