using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ADD_SCRATCHMap : EntityTypeConfiguration<ADD_SCRATCH>
    {
        public ADD_SCRATCHMap()
        {
            // Primary Key
            this.HasKey(t => t.AddID);

            // Properties
            this.Property(t => t.Username)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ADD_SCRATCH");
            this.Property(t => t.AddID).HasColumnName("AddID");
            this.Property(t => t.HorseShowID).HasColumnName("HorseShowID");
            this.Property(t => t.ScheduleID).HasColumnName("ScheduleID");
            this.Property(t => t.BackID).HasColumnName("BackID");
            this.Property(t => t.Added).HasColumnName("Added");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Entered).HasColumnName("Entered");
            this.Property(t => t.UpdateID).HasColumnName("UpdateID");

            // Relationships
            this.HasRequired(t => t.SCHEDULE)
                .WithMany(t => t.ADD_SCRATCH)
                .HasForeignKey(d => d.ScheduleID);

        }
    }
}
