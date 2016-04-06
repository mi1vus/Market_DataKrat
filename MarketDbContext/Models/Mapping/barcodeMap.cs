using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MarketDbContext.Models.Mapping
{
    public class barcodeMap : EntityTypeConfiguration<barcode>
    {
        public barcodeMap()
        {
            // Primary Key
            this.HasKey(t => t.id_bar_code);

            // Properties
            this.Property(t => t.id_bar_code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bar_code)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("barcodes");
            this.Property(t => t.id_bar_code).HasColumnName("id_bar_code");
            this.Property(t => t.bar_code_quantity).HasColumnName("bar_code_quantity");
            this.Property(t => t.bar_code).HasColumnName("bar_code");
            this.Property(t => t.bar_code_price).HasColumnName("bar_code_price");
            this.Property(t => t.id_good).HasColumnName("id_good");
            this.Property(t => t.Unused).HasColumnName("Unused");
            this.Property(t => t.ask_quantity).HasColumnName("ask_quantity");
            this.Property(t => t.ask_serial).HasColumnName("ask_serial");

            // Relationships
            this.HasOptional(t => t.good)
                .WithMany(t => t.barcodes)
                .HasForeignKey(d => d.id_good);

        }
    }
}
