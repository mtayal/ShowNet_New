using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class COMMANDMap : EntityTypeConfiguration<COMMAND>
    {
        public COMMANDMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("COMMAND");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.IsComplete).HasColumnName("IsComplete");
            this.Property(t => t.CommandType).HasColumnName("CommandType");
        }
    }
}
