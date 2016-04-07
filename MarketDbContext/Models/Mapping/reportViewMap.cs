using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MarketDbContext.Models.Mapping
{
    public class reportViewMap : EntityTypeConfiguration<reportView>
    {
        public reportViewMap()
        {
            HasKey(t => t.id);

            // Table & Column Mappings
            this.ToTable("ReportView");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.dateBuy).HasColumnName("dateBuy");
            this.Property(t => t.dateReturn).HasColumnName("dateReturn");
            this.Property(t => t.summBuy).HasColumnName("summBuy");
            this.Property(t => t.summReturn).HasColumnName("summReturn");
        }
    }
}
