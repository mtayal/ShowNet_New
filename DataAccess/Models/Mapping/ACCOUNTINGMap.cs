using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ACCOUNTINGMap : EntityTypeConfiguration<ACCOUNTING>
    {
        public ACCOUNTINGMap()
        {
            // Primary Key
            this.HasKey(t => t.ACCOUNTID);

            // Properties
            this.Property(t => t.MODIFIEDBY)
                .HasMaxLength(50);

            this.Property(t => t.CREATEDBY)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ACCOUNTING");
            this.Property(t => t.ACCOUNTID).HasColumnName("ACCOUNTID");
            this.Property(t => t.MEMBERID).HasColumnName("MEMBERID");
            this.Property(t => t.STARTING_BALANCE).HasColumnName("STARTING_BALANCE");
            this.Property(t => t.BALANCE).HasColumnName("BALANCE");
            this.Property(t => t.CREDIT_LIMIT).HasColumnName("CREDIT_LIMIT");
            this.Property(t => t.ENABLED).HasColumnName("ENABLED");
            this.Property(t => t.DATEMODIFIED).HasColumnName("DATEMODIFIED");
            this.Property(t => t.MODIFIEDBY).HasColumnName("MODIFIEDBY");
            this.Property(t => t.VERSION).HasColumnName("VERSION");
            this.Property(t => t.DATECREATED).HasColumnName("DATECREATED");
            this.Property(t => t.CREATEDBY).HasColumnName("CREATEDBY");

            // Relationships
            this.HasRequired(t => t.MEMBER_DETAILS)
                .WithMany(t => t.ACCOUNTINGs)
                .HasForeignKey(d => d.MEMBERID);
            this.HasRequired(t => t.MEMBER_DETAILS1)
                .WithMany(t => t.ACCOUNTINGs1)
                .HasForeignKey(d => d.MEMBERID);
            this.HasRequired(t => t.MEMBER_DETAILS2)
                .WithMany(t => t.ACCOUNTINGs2)
                .HasForeignKey(d => d.MEMBERID);

        }
    }
}
