using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MarketDbContext.Models.Mapping
{
    public class check_headMap : EntityTypeConfiguration<check_head>
    {
        public check_headMap()
        {
            // Primary Key
            this.HasKey(t => t.id_check);

            // Properties
            // Table & Column Mappings
            this.ToTable("check_head");
            this.Property(t => t.id_check).HasColumnName("id_check");
            this.Property(t => t.number).HasColumnName("number");
            this.Property(t => t.datetime).HasColumnName("datetime");
            this.Property(t => t.summ).HasColumnName("summ");
            this.Property(t => t.direction).HasColumnName("direction");
        }
    }
}
