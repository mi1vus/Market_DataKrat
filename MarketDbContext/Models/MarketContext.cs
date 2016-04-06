using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MarketDbContext.Models.Mapping;

namespace MarketDbContext.Models
{
    public partial class MarketContext : DbContext
    {
        static MarketContext()
        {
            Database.SetInitializer<MarketContext>(null);
        }

        public MarketContext()
            : base("Name=MarketContext")
        {
        }

        public DbSet<barcode> barcodes { get; set; }
        public DbSet<check_head> check_head { get; set; }
        public DbSet<check_pos> check_pos { get; set; }
        public DbSet<good> goods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new barcodeMap());
            modelBuilder.Configurations.Add(new check_headMap());
            modelBuilder.Configurations.Add(new check_posMap());
            modelBuilder.Configurations.Add(new goodMap());
        }
    }
}
