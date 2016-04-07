using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using MarketDbContext.Models.Mapping;
using MarketDbContext.Models;

namespace MarketDbContext
{
    public partial class MarketContext : DbContext
    {
        static MarketContext()
        {
            Database.SetInitializer<MarketContext>(null);
        }

        public MarketContext(string connString)
            : base(connString)
        {
        }

        public void SaveIfNoError()
        {
            string errMsg = "";
            if (GetValidationErrors().Any())
            {
                errMsg = GetValidationErrors().SelectMany(
                    validationResults => validationResults.ValidationErrors)
                    .Aggregate(errMsg, (current, error) => current + string.Format("Entity Property: {0}, Error {1}", error.PropertyName, error.ErrorMessage));

                throw new Exception(errMsg);
            }
            else
            {
                SaveChanges();
            }
        }

        public DbSet<barcode> barcodes { get; set; }
        public DbSet<check_head> check_head { get; set; }
        public DbSet<check_pos> check_pos { get; set; }
        public DbSet<good> goods { get; set; }
        public DbSet<reportView> reportView { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new barcodeMap());
            modelBuilder.Configurations.Add(new check_headMap());
            modelBuilder.Configurations.Add(new check_posMap());
            modelBuilder.Configurations.Add(new goodMap());
            modelBuilder.Configurations.Add(new reportViewMap());

        }
    }
}
