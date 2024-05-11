using DataVaultDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace OLTPDatabaseCore.DatabaseContext
{
    public class DWHDbContext : DbContext
    {
        public DWHDbContext()
        { }

        public DWHDbContext(DbContextOptions<DWHDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DWH"));
        }

        public DbSet<CompanyHub> CompanyHub { get; set; }

        public DbSet<CompanySat> CompanySat { get; set; }
        
        public DbSet<GoodsHub> GoodsHub { get; set; }
       
        public DbSet<GoodsSat> GoodsSat { get; set; }
       
        public DbSet<OrderCompanyLink> OrderCompanyLink { get; set; }
       
        public DbSet<OrderCompanyLinkSat> OrderCompanyLinkSat { get; set; }
       
        public DbSet<OrderGoodsLink> OrderGoodsLink { get; set; }
     
        public DbSet<OrderGoodsLinkSat> OrderGoodsLinkSat { get; set; }

        public DbSet<OrderHub> OrderHub { get; set; }
       
        public DbSet<OrderSat> OrderSat { get; set; }
    }
}
