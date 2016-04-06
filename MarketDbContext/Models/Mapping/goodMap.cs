using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MarketDbContext.Models.Mapping
{
    public class goodMap : EntityTypeConfiguration<good>
    {
        public goodMap()
        {
            // Primary Key
            this.HasKey(t => t.id_good);

            // Properties
            this.Property(t => t.name_good)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.id_good)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BarCodeDefault)
                .HasMaxLength(20);

            this.Property(t => t.articul)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.short_name_good)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("goods");
            this.Property(t => t.name_good).HasColumnName("name_good");
            this.Property(t => t.id_good).HasColumnName("id_good");
            this.Property(t => t.NDS).HasColumnName("NDS");
            this.Property(t => t.NSP).HasColumnName("NSP");
            this.Property(t => t.BarCodeDefault).HasColumnName("BarCodeDefault");
            this.Property(t => t.id_country).HasColumnName("id_country");
            this.Property(t => t.id_producer).HasColumnName("id_producer");
            this.Property(t => t.id_measure).HasColumnName("id_measure");
            this.Property(t => t.articul).HasColumnName("articul");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.unused).HasColumnName("unused");
            this.Property(t => t.plu).HasColumnName("plu");
            this.Property(t => t.min_price).HasColumnName("min_price");
            this.Property(t => t.last_change).HasColumnName("last_change");
            this.Property(t => t.id_user_change).HasColumnName("id_user_change");
            this.Property(t => t.short_name_good).HasColumnName("short_name_good");
            this.Property(t => t.id_type_good).HasColumnName("id_type_good");
            this.Property(t => t.remains_rule).HasColumnName("remains_rule");
        }
    }
}
