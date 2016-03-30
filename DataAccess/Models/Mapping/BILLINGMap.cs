using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class BILLINGMap : EntityTypeConfiguration<BILLING>
    {
        public BILLINGMap()
        {
            // Primary Key
            this.HasKey(t => t.BILLING_ID);

            // Properties
            this.Property(t => t.DESCRIPTION)
                .HasMaxLength(100);

            this.Property(t => t.CREATED_BY)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MODIFIED_BY)
                .HasMaxLength(50);

            this.Property(t => t.TRANSACTION_NUMBER)
                .HasMaxLength(50);

            this.Property(t => t.TRANSACTION_GATEWAY)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("BILLING");
            this.Property(t => t.BILLING_ID).HasColumnName("BILLING_ID");
            this.Property(t => t.AMOUNT).HasColumnName("AMOUNT");
            this.Property(t => t.QUANTITY).HasColumnName("QUANTITY");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
            this.Property(t => t.TRANSACTION_DATE).HasColumnName("TRANSACTION_DATE");
            this.Property(t => t.DATE_CREATED).HasColumnName("DATE_CREATED");
            this.Property(t => t.CREATED_BY).HasColumnName("CREATED_BY");
            this.Property(t => t.DATE_MODIFIED).HasColumnName("DATE_MODIFIED");
            this.Property(t => t.MODIFIED_BY).HasColumnName("MODIFIED_BY");
            this.Property(t => t.ACCOUNTID).HasColumnName("ACCOUNTID");
            this.Property(t => t.BILLING_TYPE_ID).HasColumnName("BILLING_TYPE_ID");
            this.Property(t => t.PAYMENT_TYPE_ID).HasColumnName("PAYMENT_TYPE_ID");
            this.Property(t => t.TRANSACTION_STATUS).HasColumnName("TRANSACTION_STATUS");
            this.Property(t => t.TRANSACTION_NUMBER).HasColumnName("TRANSACTION_NUMBER");
            this.Property(t => t.TRANSACTION_GATEWAY).HasColumnName("TRANSACTION_GATEWAY");

            // Relationships
            this.HasOptional(t => t.ACCOUNTING)
                .WithMany(t => t.BILLINGs)
                .HasForeignKey(d => d.ACCOUNTID);
            this.HasOptional(t => t.ACCOUNTING1)
                .WithMany(t => t.BILLINGs1)
                .HasForeignKey(d => d.ACCOUNTID);
            this.HasOptional(t => t.ACCOUNTING2)
                .WithMany(t => t.BILLINGs2)
                .HasForeignKey(d => d.ACCOUNTID);
            this.HasRequired(t => t.BILLING_TYPE)
                .WithMany(t => t.BILLINGs)
                .HasForeignKey(d => d.BILLING_TYPE_ID);
            this.HasRequired(t => t.BILLING_TYPE1)
                .WithMany(t => t.BILLINGs1)
                .HasForeignKey(d => d.PAYMENT_TYPE_ID);

        }
    }
}
