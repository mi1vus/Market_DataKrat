using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MarketDbContext.Models.Mapping
{
    public class check_posMap : EntityTypeConfiguration<check_pos>
    {
        public check_posMap()
        {
            // Primary Key
            this.HasKey(t => new { t.num_pos, t.id_check });

            // Properties
            this.Property(t => t.num_pos)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id_check)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("check_pos");
            this.Property(t => t.num_pos).HasColumnName("num_pos");
            this.Property(t => t.id_check).HasColumnName("id_check");
            this.Property(t => t.quant).HasColumnName("quant");
            this.Property(t => t.summ_pos).HasColumnName("summ_pos");
            this.Property(t => t.id_good).HasColumnName("id_good");

            // Relationships
            this.HasRequired(t => t.check_head)
                .WithMany(t => t.check_pos)
                .HasForeignKey(d => d.id_check);
            this.HasRequired(t => t.good)
                .WithMany(t => t.check_pos)
                .HasForeignKey(d => d.id_good);

        }
    }
}
