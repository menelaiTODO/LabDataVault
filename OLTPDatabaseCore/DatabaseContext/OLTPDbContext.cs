using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OLTPDatabaseCore.Models;

namespace OLTPDatabaseCore.DatabaseContext
{
    public class OLTPDbContext : DbContext
    {
        public OLTPDbContext()
        { }

        public OLTPDbContext(DbContextOptions<OLTPDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("OLTP"));
        }

        /// <summary>
        /// Компании
        /// </summary>
        public DbSet<Company> Companies { get; set; }

        /// <summary>
        /// Товары
        /// </summary>
        public DbSet<Goods> Goods { get; set; }

        /// <summary>
        /// Заказы
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Многие ко многим. Товары заказа
        /// </summary>
        public DbSet<OrderGoods> OrderGoods{ get; set; }
    }
}
